using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
//using Newtonsoft.Json.Serialization;

namespace Couchbase.Linq.QueryGeneration.MemberNameResolvers
{
    /// <summary>
    /// Implementation of <see cref="IMemberNameResolver"/> which uses a Newtonsoft.Json
    /// <see cref="IJsonTypeInfoResolver"/> to resolve member names.
    /// </summary>
    /// <remarks>
    /// Used for backwards compatibility with older implementations of <see cref="Couchbase.Core.IO.Serializers.ITypeSerializer"/>
    /// which don't have a GetMemberName implementation like <see cref="Couchbase.Core.IO.Serializers.IExtendedTypeSerializer"/>.
    /// </remarks>
    internal class JsonNetMemberNameResolver : IMemberNameResolver
    {
        private readonly IJsonTypeInfoResolver _contractResolver;

        public JsonNetMemberNameResolver(IJsonTypeInfoResolver contractResolver)
        {
            _contractResolver = contractResolver ?? throw new ArgumentNullException(nameof(contractResolver));
        }

        public bool TryResolveMemberName(MemberInfo member, [MaybeNullWhen(false)] out string memberName)
        {
            memberName = null;

            if (member == null)
                return false;

            var contract = _contractResolver.GetTypeInfo(member.DeclaringType, JsonSerializerOptions.Default);

            if (contract.GetType() == typeof (JsonObjectContract) &&
                ((JsonObjectContract) contract).Properties.Any(p => p.UnderlyingName == member.Name && !p.Ignored))
            {
                memberName =
                    ((JsonObjectContract) contract).Properties.First(p => p.UnderlyingName == member.Name).PropertyName;
                return true;
            }

            return false;
        }
    }
}
