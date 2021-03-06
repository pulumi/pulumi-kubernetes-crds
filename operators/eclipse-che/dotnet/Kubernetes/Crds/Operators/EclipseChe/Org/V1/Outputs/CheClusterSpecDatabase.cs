// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Org.V1
{

    [OutputType]
    public sealed class CheClusterSpecDatabase
    {
        /// <summary>
        /// Postgres database name that the Che server uses to connect to the DB. Defaults to `dbche`.
        /// </summary>
        public readonly string ChePostgresDb;
        /// <summary>
        /// Postgres Database hostname that the Che server uses to connect to. Defaults to postgres. This value should be overridden ONLY when using an external database (see field `externalDb`). In the default case it will be automatically set by the operator.
        /// </summary>
        public readonly string ChePostgresHostName;
        /// <summary>
        /// Postgres password that the Che server should use to connect to the DB. If omitted or left blank, it will be set to an auto-generated value.
        /// </summary>
        public readonly string ChePostgresPassword;
        /// <summary>
        /// Postgres Database port that the Che server uses to connect to. Defaults to 5432. This value should be overridden ONLY when using an external database (see field `externalDb`). In the default case it will be automatically set by the operator.
        /// </summary>
        public readonly string ChePostgresPort;
        /// <summary>
        /// The secret that contains Postgres `user` and `password` that the Che server should use to connect to the DB. If the secret is defined then `chePostgresUser` and `chePostgresPassword` are ignored. If the value is omitted or left blank then there are two scenarios: 1. `chePostgresUser` and `chePostgresPassword` are defined, then they will be used to connect to the DB. 2. `chePostgresUser` or `chePostgresPassword` are not defined, then a new secret with the name `che-postgres-secret` will be created with default value of `pgche` for `user` and with an auto-generated value for `password`.
        /// </summary>
        public readonly string ChePostgresSecret;
        /// <summary>
        /// Postgres user that the Che server should use to connect to the DB. Defaults to `pgche`.
        /// </summary>
        public readonly string ChePostgresUser;
        /// <summary>
        /// Instructs the operator on whether or not to deploy a dedicated database. By default a dedicated Postgres database is deployed as part of the Che installation. But if `externalDb` is `true`, then no dedicated database will be deployed by the operator and you might need to provide connection details to the external DB you want to use. See also all the fields starting with: `chePostgres`.
        /// </summary>
        public readonly bool ExternalDb;
        /// <summary>
        /// Overrides the container image used in the Postgres database deployment. This includes the image tag. Omit it or leave it empty to use the defaut container image provided by the operator.
        /// </summary>
        public readonly string PostgresImage;
        /// <summary>
        /// Overrides the image pull policy used in the Postgres database deployment. Default value is `Always` for `nightly` or `latest` images, and `IfNotPresent` in other cases.
        /// </summary>
        public readonly string PostgresImagePullPolicy;

        [OutputConstructor]
        private CheClusterSpecDatabase(
            string chePostgresDb,

            string chePostgresHostName,

            string chePostgresPassword,

            string chePostgresPort,

            string chePostgresSecret,

            string chePostgresUser,

            bool externalDb,

            string postgresImage,

            string postgresImagePullPolicy)
        {
            ChePostgresDb = chePostgresDb;
            ChePostgresHostName = chePostgresHostName;
            ChePostgresPassword = chePostgresPassword;
            ChePostgresPort = chePostgresPort;
            ChePostgresSecret = chePostgresSecret;
            ChePostgresUser = chePostgresUser;
            ExternalDb = externalDb;
            PostgresImage = postgresImage;
            PostgresImagePullPolicy = postgresImagePullPolicy;
        }
    }
}
