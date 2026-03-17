
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BillingUpdatePaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        BillingCreateCustomer,
        /// <summary>
        /// 
        /// </summary>
        BillingRemovePaymentMethod,
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
        BillingCancelSubscription,
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
        BillingUpdateSubscription,
        /// <summary>
        /// 
        /// </summary>
        BillingUpdateSubscriptionPlan,
        /// <summary>
        /// 
        /// </summary>
        BillingUpdateSubscriptionContractDetails,
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
        OrgDelete,
        /// <summary>
        /// 
        /// </summary>
        OrgRestore,
        /// <summary>
        /// 
        /// </summary>
        OrgInviteUser,
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
        OrgJoinFromDomain,
        /// <summary>
        /// 
        /// </summary>
        OrgJoinAutomatic,
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
        OrgRotateToken,
        /// <summary>
        /// 
        /// </summary>
        OrgSsoLogin,
        /// <summary>
        /// 
        /// </summary>
        OrgSsoJoin,
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
        OrgTokenApprovalEnabled,
        /// <summary>
        /// 
        /// </summary>
        OrgTokenApprovalDisabled,
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
        OrgTokenApprovalAuthorizationRequestRevoked,
        /// <summary>
        /// 
        /// </summary>
        OrgTokenApprovalAuthorizationRequestDenied,
        /// <summary>
        /// 
        /// </summary>
        RepoAddSecrets,
        /// <summary>
        /// 
        /// </summary>
        RepoRemoveSecrets,
        /// <summary>
        /// 
        /// </summary>
        RepoAddSecret,
        /// <summary>
        /// 
        /// </summary>
        RepoUpdateSecret,
        /// <summary>
        /// 
        /// </summary>
        RepoRemoveSecret,
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
        RepoDisable,
        /// <summary>
        /// 
        /// </summary>
        RepoRemoveDisable,
        /// <summary>
        /// 
        /// </summary>
        RepoDuplication,
        /// <summary>
        /// 
        /// </summary>
        RepoDeleteDoi,
        /// <summary>
        /// 
        /// </summary>
        RepoMove,
        /// <summary>
        /// 
        /// </summary>
        RepoUpdateResourceGroup,
        /// <summary>
        /// 
        /// </summary>
        RepoUpdateSettings,
        /// <summary>
        /// 
        /// </summary>
        RepoAddVariable,
        /// <summary>
        /// 
        /// </summary>
        RepoUpdateVariable,
        /// <summary>
        /// 
        /// </summary>
        RepoRemoveVariable,
        /// <summary>
        /// 
        /// </summary>
        RepoAddVariables,
        /// <summary>
        /// 
        /// </summary>
        RepoRemoveVariables,
        /// <summary>
        /// 
        /// </summary>
        RepoDeleteLfsFile,
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
        SpacesUpdateHardware,
        /// <summary>
        /// 
        /// </summary>
        SpacesUpdateSleepTime,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupCreate,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupAddUsers,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupRemoveUsers,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupChangeRole,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupSettings,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupDelete,
        /// <summary>
        /// 
        /// </summary>
        JobsCreate,
        /// <summary>
        /// 
        /// </summary>
        JobsCancel,
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
        ScheduledJobSuspend,
        /// <summary>
        /// 
        /// </summary>
        ScheduledJobRun,
        /// <summary>
        /// 
        /// </summary>
        ScheduledJobUpdateSchedule,
        /// <summary>
        /// 
        /// </summary>
        OauthToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemType value)
        {
            return value switch
            {
                ResponseItemType.BillingUpdatePaymentMethod => "billing.update_payment_method",
                ResponseItemType.BillingCreateCustomer => "billing.create_customer",
                ResponseItemType.BillingRemovePaymentMethod => "billing.remove_payment_method",
                ResponseItemType.BillingAwsAdd => "billing.aws_add",
                ResponseItemType.BillingAwsRemove => "billing.aws_remove",
                ResponseItemType.BillingGcpAdd => "billing.gcp_add",
                ResponseItemType.BillingGcpRemove => "billing.gcp_remove",
                ResponseItemType.BillingMarketplaceApprove => "billing.marketplace_approve",
                ResponseItemType.BillingCancelSubscription => "billing.cancel_subscription",
                ResponseItemType.BillingRenewSubscription => "billing.renew_subscription",
                ResponseItemType.BillingStartSubscription => "billing.start_subscription",
                ResponseItemType.BillingUnCancelSubscription => "billing.un_cancel_subscription",
                ResponseItemType.BillingUpdateSubscription => "billing.update_subscription",
                ResponseItemType.BillingUpdateSubscriptionPlan => "billing.update_subscription_plan",
                ResponseItemType.BillingUpdateSubscriptionContractDetails => "billing.update_subscription_contract_details",
                ResponseItemType.CollectionCreate => "collection.create",
                ResponseItemType.CollectionDelete => "collection.delete",
                ResponseItemType.OrgAddUser => "org.add_user",
                ResponseItemType.OrgChangeRole => "org.change_role",
                ResponseItemType.OrgCreate => "org.create",
                ResponseItemType.OrgDelete => "org.delete",
                ResponseItemType.OrgRestore => "org.restore",
                ResponseItemType.OrgInviteUser => "org.invite_user",
                ResponseItemType.OrgInviteAccept => "org.invite.accept",
                ResponseItemType.OrgInviteEmail => "org.invite.email",
                ResponseItemType.OrgJoinFromDomain => "org.join.from_domain",
                ResponseItemType.OrgJoinAutomatic => "org.join.automatic",
                ResponseItemType.OrgLeave => "org.leave",
                ResponseItemType.OrgRemoveUser => "org.remove_user",
                ResponseItemType.OrgRename => "org.rename",
                ResponseItemType.OrgRotateToken => "org.rotate_token",
                ResponseItemType.OrgSsoLogin => "org.sso_login",
                ResponseItemType.OrgSsoJoin => "org.sso_join",
                ResponseItemType.OrgUpdateJoinSettings => "org.update_join_settings",
                ResponseItemType.OrgUpdateSettings => "org.update_settings",
                ResponseItemType.OrgTokenApprovalEnabled => "org.token_approval.enabled",
                ResponseItemType.OrgTokenApprovalDisabled => "org.token_approval.disabled",
                ResponseItemType.OrgTokenApprovalAuthorizationRequest => "org.token_approval.authorization_request",
                ResponseItemType.OrgTokenApprovalAuthorizationRequestAuthorized => "org.token_approval.authorization_request.authorized",
                ResponseItemType.OrgTokenApprovalAuthorizationRequestRevoked => "org.token_approval.authorization_request.revoked",
                ResponseItemType.OrgTokenApprovalAuthorizationRequestDenied => "org.token_approval.authorization_request.denied",
                ResponseItemType.RepoAddSecrets => "repo.add_secrets",
                ResponseItemType.RepoRemoveSecrets => "repo.remove_secrets",
                ResponseItemType.RepoAddSecret => "repo.add_secret",
                ResponseItemType.RepoUpdateSecret => "repo.update_secret",
                ResponseItemType.RepoRemoveSecret => "repo.remove_secret",
                ResponseItemType.RepoCreate => "repo.create",
                ResponseItemType.RepoDelete => "repo.delete",
                ResponseItemType.RepoDisable => "repo.disable",
                ResponseItemType.RepoRemoveDisable => "repo.removeDisable",
                ResponseItemType.RepoDuplication => "repo.duplication",
                ResponseItemType.RepoDeleteDoi => "repo.delete_doi",
                ResponseItemType.RepoMove => "repo.move",
                ResponseItemType.RepoUpdateResourceGroup => "repo.update_resource_group",
                ResponseItemType.RepoUpdateSettings => "repo.update_settings",
                ResponseItemType.RepoAddVariable => "repo.add_variable",
                ResponseItemType.RepoUpdateVariable => "repo.update_variable",
                ResponseItemType.RepoRemoveVariable => "repo.remove_variable",
                ResponseItemType.RepoAddVariables => "repo.add_variables",
                ResponseItemType.RepoRemoveVariables => "repo.remove_variables",
                ResponseItemType.RepoDeleteLfsFile => "repo.delete_lfs_file",
                ResponseItemType.SpacesAddStorage => "spaces.add_storage",
                ResponseItemType.SpacesRemoveStorage => "spaces.remove_storage",
                ResponseItemType.SpacesUpdateHardware => "spaces.update_hardware",
                ResponseItemType.SpacesUpdateSleepTime => "spaces.update_sleep_time",
                ResponseItemType.ResourceGroupCreate => "resource_group.create",
                ResponseItemType.ResourceGroupAddUsers => "resource_group.add_users",
                ResponseItemType.ResourceGroupRemoveUsers => "resource_group.remove_users",
                ResponseItemType.ResourceGroupChangeRole => "resource_group.change_role",
                ResponseItemType.ResourceGroupSettings => "resource_group.settings",
                ResponseItemType.ResourceGroupDelete => "resource_group.delete",
                ResponseItemType.JobsCreate => "jobs.create",
                ResponseItemType.JobsCancel => "jobs.cancel",
                ResponseItemType.ScheduledJobCreate => "scheduled_job.create",
                ResponseItemType.ScheduledJobDelete => "scheduled_job.delete",
                ResponseItemType.ScheduledJobResume => "scheduled_job.resume",
                ResponseItemType.ScheduledJobSuspend => "scheduled_job.suspend",
                ResponseItemType.ScheduledJobRun => "scheduled_job.run",
                ResponseItemType.ScheduledJobUpdateSchedule => "scheduled_job.update_schedule",
                ResponseItemType.OauthToken => "oauth.token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "billing.update_payment_method" => ResponseItemType.BillingUpdatePaymentMethod,
                "billing.create_customer" => ResponseItemType.BillingCreateCustomer,
                "billing.remove_payment_method" => ResponseItemType.BillingRemovePaymentMethod,
                "billing.aws_add" => ResponseItemType.BillingAwsAdd,
                "billing.aws_remove" => ResponseItemType.BillingAwsRemove,
                "billing.gcp_add" => ResponseItemType.BillingGcpAdd,
                "billing.gcp_remove" => ResponseItemType.BillingGcpRemove,
                "billing.marketplace_approve" => ResponseItemType.BillingMarketplaceApprove,
                "billing.cancel_subscription" => ResponseItemType.BillingCancelSubscription,
                "billing.renew_subscription" => ResponseItemType.BillingRenewSubscription,
                "billing.start_subscription" => ResponseItemType.BillingStartSubscription,
                "billing.un_cancel_subscription" => ResponseItemType.BillingUnCancelSubscription,
                "billing.update_subscription" => ResponseItemType.BillingUpdateSubscription,
                "billing.update_subscription_plan" => ResponseItemType.BillingUpdateSubscriptionPlan,
                "billing.update_subscription_contract_details" => ResponseItemType.BillingUpdateSubscriptionContractDetails,
                "collection.create" => ResponseItemType.CollectionCreate,
                "collection.delete" => ResponseItemType.CollectionDelete,
                "org.add_user" => ResponseItemType.OrgAddUser,
                "org.change_role" => ResponseItemType.OrgChangeRole,
                "org.create" => ResponseItemType.OrgCreate,
                "org.delete" => ResponseItemType.OrgDelete,
                "org.restore" => ResponseItemType.OrgRestore,
                "org.invite_user" => ResponseItemType.OrgInviteUser,
                "org.invite.accept" => ResponseItemType.OrgInviteAccept,
                "org.invite.email" => ResponseItemType.OrgInviteEmail,
                "org.join.from_domain" => ResponseItemType.OrgJoinFromDomain,
                "org.join.automatic" => ResponseItemType.OrgJoinAutomatic,
                "org.leave" => ResponseItemType.OrgLeave,
                "org.remove_user" => ResponseItemType.OrgRemoveUser,
                "org.rename" => ResponseItemType.OrgRename,
                "org.rotate_token" => ResponseItemType.OrgRotateToken,
                "org.sso_login" => ResponseItemType.OrgSsoLogin,
                "org.sso_join" => ResponseItemType.OrgSsoJoin,
                "org.update_join_settings" => ResponseItemType.OrgUpdateJoinSettings,
                "org.update_settings" => ResponseItemType.OrgUpdateSettings,
                "org.token_approval.enabled" => ResponseItemType.OrgTokenApprovalEnabled,
                "org.token_approval.disabled" => ResponseItemType.OrgTokenApprovalDisabled,
                "org.token_approval.authorization_request" => ResponseItemType.OrgTokenApprovalAuthorizationRequest,
                "org.token_approval.authorization_request.authorized" => ResponseItemType.OrgTokenApprovalAuthorizationRequestAuthorized,
                "org.token_approval.authorization_request.revoked" => ResponseItemType.OrgTokenApprovalAuthorizationRequestRevoked,
                "org.token_approval.authorization_request.denied" => ResponseItemType.OrgTokenApprovalAuthorizationRequestDenied,
                "repo.add_secrets" => ResponseItemType.RepoAddSecrets,
                "repo.remove_secrets" => ResponseItemType.RepoRemoveSecrets,
                "repo.add_secret" => ResponseItemType.RepoAddSecret,
                "repo.update_secret" => ResponseItemType.RepoUpdateSecret,
                "repo.remove_secret" => ResponseItemType.RepoRemoveSecret,
                "repo.create" => ResponseItemType.RepoCreate,
                "repo.delete" => ResponseItemType.RepoDelete,
                "repo.disable" => ResponseItemType.RepoDisable,
                "repo.removeDisable" => ResponseItemType.RepoRemoveDisable,
                "repo.duplication" => ResponseItemType.RepoDuplication,
                "repo.delete_doi" => ResponseItemType.RepoDeleteDoi,
                "repo.move" => ResponseItemType.RepoMove,
                "repo.update_resource_group" => ResponseItemType.RepoUpdateResourceGroup,
                "repo.update_settings" => ResponseItemType.RepoUpdateSettings,
                "repo.add_variable" => ResponseItemType.RepoAddVariable,
                "repo.update_variable" => ResponseItemType.RepoUpdateVariable,
                "repo.remove_variable" => ResponseItemType.RepoRemoveVariable,
                "repo.add_variables" => ResponseItemType.RepoAddVariables,
                "repo.remove_variables" => ResponseItemType.RepoRemoveVariables,
                "repo.delete_lfs_file" => ResponseItemType.RepoDeleteLfsFile,
                "spaces.add_storage" => ResponseItemType.SpacesAddStorage,
                "spaces.remove_storage" => ResponseItemType.SpacesRemoveStorage,
                "spaces.update_hardware" => ResponseItemType.SpacesUpdateHardware,
                "spaces.update_sleep_time" => ResponseItemType.SpacesUpdateSleepTime,
                "resource_group.create" => ResponseItemType.ResourceGroupCreate,
                "resource_group.add_users" => ResponseItemType.ResourceGroupAddUsers,
                "resource_group.remove_users" => ResponseItemType.ResourceGroupRemoveUsers,
                "resource_group.change_role" => ResponseItemType.ResourceGroupChangeRole,
                "resource_group.settings" => ResponseItemType.ResourceGroupSettings,
                "resource_group.delete" => ResponseItemType.ResourceGroupDelete,
                "jobs.create" => ResponseItemType.JobsCreate,
                "jobs.cancel" => ResponseItemType.JobsCancel,
                "scheduled_job.create" => ResponseItemType.ScheduledJobCreate,
                "scheduled_job.delete" => ResponseItemType.ScheduledJobDelete,
                "scheduled_job.resume" => ResponseItemType.ScheduledJobResume,
                "scheduled_job.suspend" => ResponseItemType.ScheduledJobSuspend,
                "scheduled_job.run" => ResponseItemType.ScheduledJobRun,
                "scheduled_job.update_schedule" => ResponseItemType.ScheduledJobUpdateSchedule,
                "oauth.token" => ResponseItemType.OauthToken,
                _ => null,
            };
        }
    }
}