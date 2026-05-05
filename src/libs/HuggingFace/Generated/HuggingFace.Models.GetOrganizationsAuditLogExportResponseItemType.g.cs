
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsAuditLogExportResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BillingAwsAdd,
        /// <summary>
        /// 
        /// </summary>
        BillingAwsRemove,
        /// <summary>
        /// 
        /// </summary>
        BillingCancelSubscription,
        /// <summary>
        /// 
        /// </summary>
        BillingCreateCustomer,
        /// <summary>
        /// 
        /// </summary>
        BillingGcpAdd,
        /// <summary>
        /// 
        /// </summary>
        BillingGcpRemove,
        /// <summary>
        /// 
        /// </summary>
        BillingMarketplaceApprove,
        /// <summary>
        /// 
        /// </summary>
        BillingRemovePaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        BillingRenewSubscription,
        /// <summary>
        /// 
        /// </summary>
        BillingStartSubscription,
        /// <summary>
        /// 
        /// </summary>
        BillingUnCancelSubscription,
        /// <summary>
        /// 
        /// </summary>
        BillingUpdatePaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        BillingUpdateSubscription,
        /// <summary>
        /// 
        /// </summary>
        BillingUpdateSubscriptionPlan,
        /// <summary>
        /// 
        /// </summary>
        CollectionCreate,
        /// <summary>
        /// 
        /// </summary>
        CollectionDelete,
        /// <summary>
        /// 
        /// </summary>
        JobsCancel,
        /// <summary>
        /// 
        /// </summary>
        JobsCreate,
        /// <summary>
        /// 
        /// </summary>
        JobsUpdateLabels,
        /// <summary>
        /// 
        /// </summary>
        OauthToken,
        /// <summary>
        /// 
        /// </summary>
        OrgAddUser,
        /// <summary>
        /// 
        /// </summary>
        OrgChangeRole,
        /// <summary>
        /// 
        /// </summary>
        OrgCreate,
        /// <summary>
        /// 
        /// </summary>
        OrgCustomRoleCreate,
        /// <summary>
        /// 
        /// </summary>
        OrgCustomRoleDelete,
        /// <summary>
        /// 
        /// </summary>
        OrgCustomRoleUpdate,
        /// <summary>
        /// 
        /// </summary>
        OrgDelete,
        /// <summary>
        /// 
        /// </summary>
        OrgInviteAccept,
        /// <summary>
        /// 
        /// </summary>
        OrgInviteEmail,
        /// <summary>
        /// 
        /// </summary>
        OrgInviteUser,
        /// <summary>
        /// 
        /// </summary>
        OrgJoinAutomatic,
        /// <summary>
        /// 
        /// </summary>
        OrgJoinFromDomain,
        /// <summary>
        /// 
        /// </summary>
        OrgLeave,
        /// <summary>
        /// 
        /// </summary>
        OrgRemoveUser,
        /// <summary>
        /// 
        /// </summary>
        OrgRename,
        /// <summary>
        /// 
        /// </summary>
        OrgRestore,
        /// <summary>
        /// 
        /// </summary>
        OrgRotateToken,
        /// <summary>
        /// 
        /// </summary>
        OrgSsoJoin,
        /// <summary>
        /// 
        /// </summary>
        OrgSsoLogin,
        /// <summary>
        /// 
        /// </summary>
        OrgTokenApprovalAuthorizationRequest,
        /// <summary>
        /// 
        /// </summary>
        OrgTokenApprovalAuthorizationRequestAuthorized,
        /// <summary>
        /// 
        /// </summary>
        OrgTokenApprovalAuthorizationRequestDenied,
        /// <summary>
        /// 
        /// </summary>
        OrgTokenApprovalAuthorizationRequestRevoked,
        /// <summary>
        /// 
        /// </summary>
        OrgTokenApprovalDisabled,
        /// <summary>
        /// 
        /// </summary>
        OrgTokenApprovalEnabled,
        /// <summary>
        /// 
        /// </summary>
        OrgUpdateJoinSettings,
        /// <summary>
        /// 
        /// </summary>
        OrgUpdateSettings,
        /// <summary>
        /// 
        /// </summary>
        RepoAddSecret,
        /// <summary>
        /// 
        /// </summary>
        RepoAddSecrets,
        /// <summary>
        /// 
        /// </summary>
        RepoAddVariable,
        /// <summary>
        /// 
        /// </summary>
        RepoAddVariables,
        /// <summary>
        /// 
        /// </summary>
        RepoCreate,
        /// <summary>
        /// 
        /// </summary>
        RepoDelete,
        /// <summary>
        /// 
        /// </summary>
        RepoDeleteDoi,
        /// <summary>
        /// 
        /// </summary>
        RepoDeleteLfsFile,
        /// <summary>
        /// 
        /// </summary>
        RepoDisable,
        /// <summary>
        /// 
        /// </summary>
        RepoDuplication,
        /// <summary>
        /// 
        /// </summary>
        RepoMove,
        /// <summary>
        /// 
        /// </summary>
        RepoRemoveDisable,
        /// <summary>
        /// 
        /// </summary>
        RepoRemoveSecret,
        /// <summary>
        /// 
        /// </summary>
        RepoRemoveSecrets,
        /// <summary>
        /// 
        /// </summary>
        RepoRemoveVariable,
        /// <summary>
        /// 
        /// </summary>
        RepoRemoveVariables,
        /// <summary>
        /// 
        /// </summary>
        RepoUpdateResourceGroup,
        /// <summary>
        /// 
        /// </summary>
        RepoUpdateSecret,
        /// <summary>
        /// 
        /// </summary>
        RepoUpdateSettings,
        /// <summary>
        /// 
        /// </summary>
        RepoUpdateVariable,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupAddUsers,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupChangeRole,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupCreate,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupDelete,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupRemoveUsers,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupSettings,
        /// <summary>
        /// 
        /// </summary>
        ScheduledJobCreate,
        /// <summary>
        /// 
        /// </summary>
        ScheduledJobDelete,
        /// <summary>
        /// 
        /// </summary>
        ScheduledJobResume,
        /// <summary>
        /// 
        /// </summary>
        ScheduledJobRun,
        /// <summary>
        /// 
        /// </summary>
        ScheduledJobSuspend,
        /// <summary>
        /// 
        /// </summary>
        ScheduledJobUpdateLabels,
        /// <summary>
        /// 
        /// </summary>
        ScheduledJobUpdateSchedule,
        /// <summary>
        /// 
        /// </summary>
        SpacesAddStorage,
        /// <summary>
        /// 
        /// </summary>
        SpacesRemoveStorage,
        /// <summary>
        /// 
        /// </summary>
        SpacesRemoveVolumes,
        /// <summary>
        /// 
        /// </summary>
        SpacesSetVolumes,
        /// <summary>
        /// 
        /// </summary>
        SpacesUpdateHardware,
        /// <summary>
        /// 
        /// </summary>
        SpacesUpdateSleepTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsAuditLogExportResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsAuditLogExportResponseItemType value)
        {
            return value switch
            {
                GetOrganizationsAuditLogExportResponseItemType.BillingAwsAdd => "billing.aws_add",
                GetOrganizationsAuditLogExportResponseItemType.BillingAwsRemove => "billing.aws_remove",
                GetOrganizationsAuditLogExportResponseItemType.BillingCancelSubscription => "billing.cancel_subscription",
                GetOrganizationsAuditLogExportResponseItemType.BillingCreateCustomer => "billing.create_customer",
                GetOrganizationsAuditLogExportResponseItemType.BillingGcpAdd => "billing.gcp_add",
                GetOrganizationsAuditLogExportResponseItemType.BillingGcpRemove => "billing.gcp_remove",
                GetOrganizationsAuditLogExportResponseItemType.BillingMarketplaceApprove => "billing.marketplace_approve",
                GetOrganizationsAuditLogExportResponseItemType.BillingRemovePaymentMethod => "billing.remove_payment_method",
                GetOrganizationsAuditLogExportResponseItemType.BillingRenewSubscription => "billing.renew_subscription",
                GetOrganizationsAuditLogExportResponseItemType.BillingStartSubscription => "billing.start_subscription",
                GetOrganizationsAuditLogExportResponseItemType.BillingUnCancelSubscription => "billing.un_cancel_subscription",
                GetOrganizationsAuditLogExportResponseItemType.BillingUpdatePaymentMethod => "billing.update_payment_method",
                GetOrganizationsAuditLogExportResponseItemType.BillingUpdateSubscription => "billing.update_subscription",
                GetOrganizationsAuditLogExportResponseItemType.BillingUpdateSubscriptionPlan => "billing.update_subscription_plan",
                GetOrganizationsAuditLogExportResponseItemType.CollectionCreate => "collection.create",
                GetOrganizationsAuditLogExportResponseItemType.CollectionDelete => "collection.delete",
                GetOrganizationsAuditLogExportResponseItemType.JobsCancel => "jobs.cancel",
                GetOrganizationsAuditLogExportResponseItemType.JobsCreate => "jobs.create",
                GetOrganizationsAuditLogExportResponseItemType.JobsUpdateLabels => "jobs.update_labels",
                GetOrganizationsAuditLogExportResponseItemType.OauthToken => "oauth.token",
                GetOrganizationsAuditLogExportResponseItemType.OrgAddUser => "org.add_user",
                GetOrganizationsAuditLogExportResponseItemType.OrgChangeRole => "org.change_role",
                GetOrganizationsAuditLogExportResponseItemType.OrgCreate => "org.create",
                GetOrganizationsAuditLogExportResponseItemType.OrgCustomRoleCreate => "org.custom_role.create",
                GetOrganizationsAuditLogExportResponseItemType.OrgCustomRoleDelete => "org.custom_role.delete",
                GetOrganizationsAuditLogExportResponseItemType.OrgCustomRoleUpdate => "org.custom_role.update",
                GetOrganizationsAuditLogExportResponseItemType.OrgDelete => "org.delete",
                GetOrganizationsAuditLogExportResponseItemType.OrgInviteAccept => "org.invite.accept",
                GetOrganizationsAuditLogExportResponseItemType.OrgInviteEmail => "org.invite.email",
                GetOrganizationsAuditLogExportResponseItemType.OrgInviteUser => "org.invite_user",
                GetOrganizationsAuditLogExportResponseItemType.OrgJoinAutomatic => "org.join.automatic",
                GetOrganizationsAuditLogExportResponseItemType.OrgJoinFromDomain => "org.join.from_domain",
                GetOrganizationsAuditLogExportResponseItemType.OrgLeave => "org.leave",
                GetOrganizationsAuditLogExportResponseItemType.OrgRemoveUser => "org.remove_user",
                GetOrganizationsAuditLogExportResponseItemType.OrgRename => "org.rename",
                GetOrganizationsAuditLogExportResponseItemType.OrgRestore => "org.restore",
                GetOrganizationsAuditLogExportResponseItemType.OrgRotateToken => "org.rotate_token",
                GetOrganizationsAuditLogExportResponseItemType.OrgSsoJoin => "org.sso_join",
                GetOrganizationsAuditLogExportResponseItemType.OrgSsoLogin => "org.sso_login",
                GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalAuthorizationRequest => "org.token_approval.authorization_request",
                GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalAuthorizationRequestAuthorized => "org.token_approval.authorization_request.authorized",
                GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalAuthorizationRequestDenied => "org.token_approval.authorization_request.denied",
                GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalAuthorizationRequestRevoked => "org.token_approval.authorization_request.revoked",
                GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalDisabled => "org.token_approval.disabled",
                GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalEnabled => "org.token_approval.enabled",
                GetOrganizationsAuditLogExportResponseItemType.OrgUpdateJoinSettings => "org.update_join_settings",
                GetOrganizationsAuditLogExportResponseItemType.OrgUpdateSettings => "org.update_settings",
                GetOrganizationsAuditLogExportResponseItemType.RepoAddSecret => "repo.add_secret",
                GetOrganizationsAuditLogExportResponseItemType.RepoAddSecrets => "repo.add_secrets",
                GetOrganizationsAuditLogExportResponseItemType.RepoAddVariable => "repo.add_variable",
                GetOrganizationsAuditLogExportResponseItemType.RepoAddVariables => "repo.add_variables",
                GetOrganizationsAuditLogExportResponseItemType.RepoCreate => "repo.create",
                GetOrganizationsAuditLogExportResponseItemType.RepoDelete => "repo.delete",
                GetOrganizationsAuditLogExportResponseItemType.RepoDeleteDoi => "repo.delete_doi",
                GetOrganizationsAuditLogExportResponseItemType.RepoDeleteLfsFile => "repo.delete_lfs_file",
                GetOrganizationsAuditLogExportResponseItemType.RepoDisable => "repo.disable",
                GetOrganizationsAuditLogExportResponseItemType.RepoDuplication => "repo.duplication",
                GetOrganizationsAuditLogExportResponseItemType.RepoMove => "repo.move",
                GetOrganizationsAuditLogExportResponseItemType.RepoRemoveDisable => "repo.removeDisable",
                GetOrganizationsAuditLogExportResponseItemType.RepoRemoveSecret => "repo.remove_secret",
                GetOrganizationsAuditLogExportResponseItemType.RepoRemoveSecrets => "repo.remove_secrets",
                GetOrganizationsAuditLogExportResponseItemType.RepoRemoveVariable => "repo.remove_variable",
                GetOrganizationsAuditLogExportResponseItemType.RepoRemoveVariables => "repo.remove_variables",
                GetOrganizationsAuditLogExportResponseItemType.RepoUpdateResourceGroup => "repo.update_resource_group",
                GetOrganizationsAuditLogExportResponseItemType.RepoUpdateSecret => "repo.update_secret",
                GetOrganizationsAuditLogExportResponseItemType.RepoUpdateSettings => "repo.update_settings",
                GetOrganizationsAuditLogExportResponseItemType.RepoUpdateVariable => "repo.update_variable",
                GetOrganizationsAuditLogExportResponseItemType.ResourceGroupAddUsers => "resource_group.add_users",
                GetOrganizationsAuditLogExportResponseItemType.ResourceGroupChangeRole => "resource_group.change_role",
                GetOrganizationsAuditLogExportResponseItemType.ResourceGroupCreate => "resource_group.create",
                GetOrganizationsAuditLogExportResponseItemType.ResourceGroupDelete => "resource_group.delete",
                GetOrganizationsAuditLogExportResponseItemType.ResourceGroupRemoveUsers => "resource_group.remove_users",
                GetOrganizationsAuditLogExportResponseItemType.ResourceGroupSettings => "resource_group.settings",
                GetOrganizationsAuditLogExportResponseItemType.ScheduledJobCreate => "scheduled_job.create",
                GetOrganizationsAuditLogExportResponseItemType.ScheduledJobDelete => "scheduled_job.delete",
                GetOrganizationsAuditLogExportResponseItemType.ScheduledJobResume => "scheduled_job.resume",
                GetOrganizationsAuditLogExportResponseItemType.ScheduledJobRun => "scheduled_job.run",
                GetOrganizationsAuditLogExportResponseItemType.ScheduledJobSuspend => "scheduled_job.suspend",
                GetOrganizationsAuditLogExportResponseItemType.ScheduledJobUpdateLabels => "scheduled_job.update_labels",
                GetOrganizationsAuditLogExportResponseItemType.ScheduledJobUpdateSchedule => "scheduled_job.update_schedule",
                GetOrganizationsAuditLogExportResponseItemType.SpacesAddStorage => "spaces.add_storage",
                GetOrganizationsAuditLogExportResponseItemType.SpacesRemoveStorage => "spaces.remove_storage",
                GetOrganizationsAuditLogExportResponseItemType.SpacesRemoveVolumes => "spaces.remove_volumes",
                GetOrganizationsAuditLogExportResponseItemType.SpacesSetVolumes => "spaces.set_volumes",
                GetOrganizationsAuditLogExportResponseItemType.SpacesUpdateHardware => "spaces.update_hardware",
                GetOrganizationsAuditLogExportResponseItemType.SpacesUpdateSleepTime => "spaces.update_sleep_time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsAuditLogExportResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "billing.aws_add" => GetOrganizationsAuditLogExportResponseItemType.BillingAwsAdd,
                "billing.aws_remove" => GetOrganizationsAuditLogExportResponseItemType.BillingAwsRemove,
                "billing.cancel_subscription" => GetOrganizationsAuditLogExportResponseItemType.BillingCancelSubscription,
                "billing.create_customer" => GetOrganizationsAuditLogExportResponseItemType.BillingCreateCustomer,
                "billing.gcp_add" => GetOrganizationsAuditLogExportResponseItemType.BillingGcpAdd,
                "billing.gcp_remove" => GetOrganizationsAuditLogExportResponseItemType.BillingGcpRemove,
                "billing.marketplace_approve" => GetOrganizationsAuditLogExportResponseItemType.BillingMarketplaceApprove,
                "billing.remove_payment_method" => GetOrganizationsAuditLogExportResponseItemType.BillingRemovePaymentMethod,
                "billing.renew_subscription" => GetOrganizationsAuditLogExportResponseItemType.BillingRenewSubscription,
                "billing.start_subscription" => GetOrganizationsAuditLogExportResponseItemType.BillingStartSubscription,
                "billing.un_cancel_subscription" => GetOrganizationsAuditLogExportResponseItemType.BillingUnCancelSubscription,
                "billing.update_payment_method" => GetOrganizationsAuditLogExportResponseItemType.BillingUpdatePaymentMethod,
                "billing.update_subscription" => GetOrganizationsAuditLogExportResponseItemType.BillingUpdateSubscription,
                "billing.update_subscription_plan" => GetOrganizationsAuditLogExportResponseItemType.BillingUpdateSubscriptionPlan,
                "collection.create" => GetOrganizationsAuditLogExportResponseItemType.CollectionCreate,
                "collection.delete" => GetOrganizationsAuditLogExportResponseItemType.CollectionDelete,
                "jobs.cancel" => GetOrganizationsAuditLogExportResponseItemType.JobsCancel,
                "jobs.create" => GetOrganizationsAuditLogExportResponseItemType.JobsCreate,
                "jobs.update_labels" => GetOrganizationsAuditLogExportResponseItemType.JobsUpdateLabels,
                "oauth.token" => GetOrganizationsAuditLogExportResponseItemType.OauthToken,
                "org.add_user" => GetOrganizationsAuditLogExportResponseItemType.OrgAddUser,
                "org.change_role" => GetOrganizationsAuditLogExportResponseItemType.OrgChangeRole,
                "org.create" => GetOrganizationsAuditLogExportResponseItemType.OrgCreate,
                "org.custom_role.create" => GetOrganizationsAuditLogExportResponseItemType.OrgCustomRoleCreate,
                "org.custom_role.delete" => GetOrganizationsAuditLogExportResponseItemType.OrgCustomRoleDelete,
                "org.custom_role.update" => GetOrganizationsAuditLogExportResponseItemType.OrgCustomRoleUpdate,
                "org.delete" => GetOrganizationsAuditLogExportResponseItemType.OrgDelete,
                "org.invite.accept" => GetOrganizationsAuditLogExportResponseItemType.OrgInviteAccept,
                "org.invite.email" => GetOrganizationsAuditLogExportResponseItemType.OrgInviteEmail,
                "org.invite_user" => GetOrganizationsAuditLogExportResponseItemType.OrgInviteUser,
                "org.join.automatic" => GetOrganizationsAuditLogExportResponseItemType.OrgJoinAutomatic,
                "org.join.from_domain" => GetOrganizationsAuditLogExportResponseItemType.OrgJoinFromDomain,
                "org.leave" => GetOrganizationsAuditLogExportResponseItemType.OrgLeave,
                "org.remove_user" => GetOrganizationsAuditLogExportResponseItemType.OrgRemoveUser,
                "org.rename" => GetOrganizationsAuditLogExportResponseItemType.OrgRename,
                "org.restore" => GetOrganizationsAuditLogExportResponseItemType.OrgRestore,
                "org.rotate_token" => GetOrganizationsAuditLogExportResponseItemType.OrgRotateToken,
                "org.sso_join" => GetOrganizationsAuditLogExportResponseItemType.OrgSsoJoin,
                "org.sso_login" => GetOrganizationsAuditLogExportResponseItemType.OrgSsoLogin,
                "org.token_approval.authorization_request" => GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalAuthorizationRequest,
                "org.token_approval.authorization_request.authorized" => GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalAuthorizationRequestAuthorized,
                "org.token_approval.authorization_request.denied" => GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalAuthorizationRequestDenied,
                "org.token_approval.authorization_request.revoked" => GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalAuthorizationRequestRevoked,
                "org.token_approval.disabled" => GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalDisabled,
                "org.token_approval.enabled" => GetOrganizationsAuditLogExportResponseItemType.OrgTokenApprovalEnabled,
                "org.update_join_settings" => GetOrganizationsAuditLogExportResponseItemType.OrgUpdateJoinSettings,
                "org.update_settings" => GetOrganizationsAuditLogExportResponseItemType.OrgUpdateSettings,
                "repo.add_secret" => GetOrganizationsAuditLogExportResponseItemType.RepoAddSecret,
                "repo.add_secrets" => GetOrganizationsAuditLogExportResponseItemType.RepoAddSecrets,
                "repo.add_variable" => GetOrganizationsAuditLogExportResponseItemType.RepoAddVariable,
                "repo.add_variables" => GetOrganizationsAuditLogExportResponseItemType.RepoAddVariables,
                "repo.create" => GetOrganizationsAuditLogExportResponseItemType.RepoCreate,
                "repo.delete" => GetOrganizationsAuditLogExportResponseItemType.RepoDelete,
                "repo.delete_doi" => GetOrganizationsAuditLogExportResponseItemType.RepoDeleteDoi,
                "repo.delete_lfs_file" => GetOrganizationsAuditLogExportResponseItemType.RepoDeleteLfsFile,
                "repo.disable" => GetOrganizationsAuditLogExportResponseItemType.RepoDisable,
                "repo.duplication" => GetOrganizationsAuditLogExportResponseItemType.RepoDuplication,
                "repo.move" => GetOrganizationsAuditLogExportResponseItemType.RepoMove,
                "repo.removeDisable" => GetOrganizationsAuditLogExportResponseItemType.RepoRemoveDisable,
                "repo.remove_secret" => GetOrganizationsAuditLogExportResponseItemType.RepoRemoveSecret,
                "repo.remove_secrets" => GetOrganizationsAuditLogExportResponseItemType.RepoRemoveSecrets,
                "repo.remove_variable" => GetOrganizationsAuditLogExportResponseItemType.RepoRemoveVariable,
                "repo.remove_variables" => GetOrganizationsAuditLogExportResponseItemType.RepoRemoveVariables,
                "repo.update_resource_group" => GetOrganizationsAuditLogExportResponseItemType.RepoUpdateResourceGroup,
                "repo.update_secret" => GetOrganizationsAuditLogExportResponseItemType.RepoUpdateSecret,
                "repo.update_settings" => GetOrganizationsAuditLogExportResponseItemType.RepoUpdateSettings,
                "repo.update_variable" => GetOrganizationsAuditLogExportResponseItemType.RepoUpdateVariable,
                "resource_group.add_users" => GetOrganizationsAuditLogExportResponseItemType.ResourceGroupAddUsers,
                "resource_group.change_role" => GetOrganizationsAuditLogExportResponseItemType.ResourceGroupChangeRole,
                "resource_group.create" => GetOrganizationsAuditLogExportResponseItemType.ResourceGroupCreate,
                "resource_group.delete" => GetOrganizationsAuditLogExportResponseItemType.ResourceGroupDelete,
                "resource_group.remove_users" => GetOrganizationsAuditLogExportResponseItemType.ResourceGroupRemoveUsers,
                "resource_group.settings" => GetOrganizationsAuditLogExportResponseItemType.ResourceGroupSettings,
                "scheduled_job.create" => GetOrganizationsAuditLogExportResponseItemType.ScheduledJobCreate,
                "scheduled_job.delete" => GetOrganizationsAuditLogExportResponseItemType.ScheduledJobDelete,
                "scheduled_job.resume" => GetOrganizationsAuditLogExportResponseItemType.ScheduledJobResume,
                "scheduled_job.run" => GetOrganizationsAuditLogExportResponseItemType.ScheduledJobRun,
                "scheduled_job.suspend" => GetOrganizationsAuditLogExportResponseItemType.ScheduledJobSuspend,
                "scheduled_job.update_labels" => GetOrganizationsAuditLogExportResponseItemType.ScheduledJobUpdateLabels,
                "scheduled_job.update_schedule" => GetOrganizationsAuditLogExportResponseItemType.ScheduledJobUpdateSchedule,
                "spaces.add_storage" => GetOrganizationsAuditLogExportResponseItemType.SpacesAddStorage,
                "spaces.remove_storage" => GetOrganizationsAuditLogExportResponseItemType.SpacesRemoveStorage,
                "spaces.remove_volumes" => GetOrganizationsAuditLogExportResponseItemType.SpacesRemoveVolumes,
                "spaces.set_volumes" => GetOrganizationsAuditLogExportResponseItemType.SpacesSetVolumes,
                "spaces.update_hardware" => GetOrganizationsAuditLogExportResponseItemType.SpacesUpdateHardware,
                "spaces.update_sleep_time" => GetOrganizationsAuditLogExportResponseItemType.SpacesUpdateSleepTime,
                _ => null,
            };
        }
    }
}