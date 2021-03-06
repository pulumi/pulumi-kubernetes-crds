// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Postgresql.V1Alpha1
{

    [OutputType]
    public sealed class BackupStatus
    {
        /// <summary>
        /// Namespace  of the secret object with the Aws data to allow send the backup files to the AWS storage
        /// </summary>
        public readonly string AwsCredentialsSecretNamespace;
        /// <summary>
        /// Name  of the secret object with the Aws data to allow send the backup files to the AWS storage
        /// </summary>
        public readonly string AwsSecretName;
        /// <summary>
        /// Will be as "OK when all objects are created successfully
        /// </summary>
        public readonly string BackupStatus;
        /// <summary>
        /// Name of the CronJob object created and managed by it to schedule the backup job
        /// </summary>
        public readonly string CronJobName;
        /// <summary>
        /// Status of the CronJob object
        /// </summary>
        public readonly ImmutableDictionary<string, object> CronJobStatus;
        /// <summary>
        /// Name of the secret object created with the database data to allow the backup image connect to the database
        /// </summary>
        public readonly string DbSecretName;
        /// <summary>
        /// Name  of the secret object with the Encryption GPG Key
        /// </summary>
        public readonly string EncryptKeySecretName;
        /// <summary>
        /// Namespace of the secret object with the Encryption GPG Key
        /// </summary>
        public readonly string EncryptKeySecretNamespace;
        /// <summary>
        /// Boolean value which has true when it has an EncryptionKey to be used to send the backup files
        /// </summary>
        public readonly bool HasEncryptKey;
        /// <summary>
        /// Boolean value which has true when the Database Pod was found in order to create the secret with the database data to allow the backup image connect into it. 
        /// </summary>
        public readonly bool IsDatabasePodFound;
        /// <summary>
        /// Boolean value which has true when the Service Database Pod was found in order to create the secret with the database data to allow the backup image connect into it.
        /// </summary>
        public readonly bool IsDatabaseServiceFound;

        [OutputConstructor]
        private BackupStatus(
            string awsCredentialsSecretNamespace,

            string awsSecretName,

            string backupStatus,

            string cronJobName,

            ImmutableDictionary<string, object> cronJobStatus,

            string dbSecretName,

            string encryptKeySecretName,

            string encryptKeySecretNamespace,

            bool hasEncryptKey,

            bool isDatabasePodFound,

            bool isDatabaseServiceFound)
        {
            AwsCredentialsSecretNamespace = awsCredentialsSecretNamespace;
            AwsSecretName = awsSecretName;
            BackupStatus = backupStatus;
            CronJobName = cronJobName;
            CronJobStatus = cronJobStatus;
            DbSecretName = dbSecretName;
            EncryptKeySecretName = encryptKeySecretName;
            EncryptKeySecretNamespace = encryptKeySecretNamespace;
            HasEncryptKey = hasEncryptKey;
            IsDatabasePodFound = isDatabasePodFound;
            IsDatabaseServiceFound = isDatabaseServiceFound;
        }
    }
}
