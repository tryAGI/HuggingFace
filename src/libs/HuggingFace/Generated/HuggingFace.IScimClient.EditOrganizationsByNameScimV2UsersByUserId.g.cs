#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Update SCIM user<br/>
        /// Update an attribute of a SCIM user. Modify individual attributes using Operations format. Just provide the changes you want to make using add, remove (only `externalId` is supported), or replace operations.<br/>
        ///  If you set `active` to `false`, the user will be deprovisioned from the organization. <br/>
        /// Complicated SCIM `path` values are not supported like `emails[type eq 'work'].value`.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response18> EditOrganizationsByNameScimV2UsersByUserIdAsync(
            string name,
            string userId,

            global::HuggingFace.Request11 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update SCIM user<br/>
        /// Update an attribute of a SCIM user. Modify individual attributes using Operations format. Just provide the changes you want to make using add, remove (only `externalId` is supported), or replace operations.<br/>
        ///  If you set `active` to `false`, the user will be deprovisioned from the organization. <br/>
        /// Complicated SCIM `path` values are not supported like `emails[type eq 'work'].value`.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="schemas"></param>
        /// <param name="operations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response18> EditOrganizationsByNameScimV2UsersByUserIdAsync(
            string name,
            string userId,
            global::System.Collections.Generic.IList<string> schemas,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestOperation> operations,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}