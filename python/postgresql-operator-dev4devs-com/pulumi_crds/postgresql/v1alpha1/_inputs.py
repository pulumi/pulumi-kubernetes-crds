# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from ... import _utilities, _tables

__all__ = [
    'BackupSpecArgs',
    'BackupStatusArgs',
]

@pulumi.input_type
class BackupSpecArgs:
    def __init__(__self__, *,
                 aws_access_key_id: Optional[pulumi.Input[str]] = None,
                 aws_s3_bucket_name: Optional[pulumi.Input[str]] = None,
                 aws_secret_access_key: Optional[pulumi.Input[str]] = None,
                 aws_secret_name: Optional[pulumi.Input[str]] = None,
                 aws_secret_namespace: Optional[pulumi.Input[str]] = None,
                 database_cr_name: Optional[pulumi.Input[str]] = None,
                 database_version: Optional[pulumi.Input[str]] = None,
                 encrypt_key_secret_name: Optional[pulumi.Input[str]] = None,
                 encrypt_key_secret_namespace: Optional[pulumi.Input[str]] = None,
                 gpg_email: Optional[pulumi.Input[str]] = None,
                 gpg_public_key: Optional[pulumi.Input[str]] = None,
                 gpg_trust_model: Optional[pulumi.Input[str]] = None,
                 image: Optional[pulumi.Input[str]] = None,
                 product_name: Optional[pulumi.Input[str]] = None,
                 schedule: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] aws_access_key_id: Key ID of AWS S3 storage. Default Value: nil Required to create the Secret with the data to allow send the backup files to AWS S3 storage.
        :param pulumi.Input[str] aws_s3_bucket_name: Name of AWS S3 storage. Default Value: nil Required to create the Secret with the AWS data to allow send the backup files to AWS S3 storage. 
        :param pulumi.Input[str] aws_secret_access_key: Secret/Token of AWS S3 storage. Default Value: nil Required to create the Secret with the data to allow send the backup files to AWS S3 storage.
        :param pulumi.Input[str] aws_secret_name: Name of the secret with the AWS data credentials pre-existing in the cluster Default Value: nil See here the template: https://github.com/integr8ly/backup-container-image/blob/master/templates/openshift/sample-config/s3-secret.yaml 
        :param pulumi.Input[str] aws_secret_namespace: Namespace of the secret with the AWS data credentials pre-existing in the cluster Default Value: nil NOTE: If the namespace be not informed then the operator will try to find it in the same namespace where it is applied 
        :param pulumi.Input[str] database_cr_name: Name of the Database CR applied which this backup will work with Default Value: database
        :param pulumi.Input[str] database_version: Database version. (E.g 9.6). Default Value: <9.6> IMPORTANT: Just the first 2 digits should be used.
        :param pulumi.Input[str] encrypt_key_secret_name: Name of the secret with the Encrypt data pre-existing in the cluster Default Value: nil See here the template: https://github.com/integr8ly/backup-container-image/blob/master/templates/openshift/sample-config/gpg-secret.yaml
        :param pulumi.Input[str] encrypt_key_secret_namespace: Namespace of the secret with the Encrypt data pre-existing in the cluster Default Value: nil NOTE: If the namespace be not informed then the operator will try to find it in the same namespace where it is applied
        :param pulumi.Input[str] gpg_email: GPG email to create the EncryptionKeySecret with this data Default Value: nil See here how to create this key : https://help.github.com/en/articles/generating-a-new-gpg-key
        :param pulumi.Input[str] gpg_public_key: GPG public key to create the EncryptionKeySecret with this data Default Value: nil See here how to create this key : https://help.github.com/en/articles/generating-a-new-gpg-key
        :param pulumi.Input[str] gpg_trust_model: GPG trust model to create the EncryptionKeySecret with this data. the default value is true when it is empty. Default Value: nil See here how to create this key : https://help.github.com/en/articles/generating-a-new-gpg-key
        :param pulumi.Input[str] image: Image:tag used to do the backup. Default Value: <quay.io/integreatly/backup-container:1.0.8> More Info: https://github.com/integr8ly/backup-container-image
        :param pulumi.Input[str] product_name: Used to create the directory where the files will be stored Default Value: <postgresql> 
        :param pulumi.Input[str] schedule: Schedule period for the CronJob. Default Value: <0 0 * * *> daily at 00:00
        """
        if aws_access_key_id is not None:
            pulumi.set(__self__, "aws_access_key_id", aws_access_key_id)
        if aws_s3_bucket_name is not None:
            pulumi.set(__self__, "aws_s3_bucket_name", aws_s3_bucket_name)
        if aws_secret_access_key is not None:
            pulumi.set(__self__, "aws_secret_access_key", aws_secret_access_key)
        if aws_secret_name is not None:
            pulumi.set(__self__, "aws_secret_name", aws_secret_name)
        if aws_secret_namespace is not None:
            pulumi.set(__self__, "aws_secret_namespace", aws_secret_namespace)
        if database_cr_name is not None:
            pulumi.set(__self__, "database_cr_name", database_cr_name)
        if database_version is not None:
            pulumi.set(__self__, "database_version", database_version)
        if encrypt_key_secret_name is not None:
            pulumi.set(__self__, "encrypt_key_secret_name", encrypt_key_secret_name)
        if encrypt_key_secret_namespace is not None:
            pulumi.set(__self__, "encrypt_key_secret_namespace", encrypt_key_secret_namespace)
        if gpg_email is not None:
            pulumi.set(__self__, "gpg_email", gpg_email)
        if gpg_public_key is not None:
            pulumi.set(__self__, "gpg_public_key", gpg_public_key)
        if gpg_trust_model is not None:
            pulumi.set(__self__, "gpg_trust_model", gpg_trust_model)
        if image is not None:
            pulumi.set(__self__, "image", image)
        if product_name is not None:
            pulumi.set(__self__, "product_name", product_name)
        if schedule is not None:
            pulumi.set(__self__, "schedule", schedule)

    @property
    @pulumi.getter(name="awsAccessKeyId")
    def aws_access_key_id(self) -> Optional[pulumi.Input[str]]:
        """
        Key ID of AWS S3 storage. Default Value: nil Required to create the Secret with the data to allow send the backup files to AWS S3 storage.
        """
        return pulumi.get(self, "aws_access_key_id")

    @aws_access_key_id.setter
    def aws_access_key_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "aws_access_key_id", value)

    @property
    @pulumi.getter(name="awsS3BucketName")
    def aws_s3_bucket_name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of AWS S3 storage. Default Value: nil Required to create the Secret with the AWS data to allow send the backup files to AWS S3 storage. 
        """
        return pulumi.get(self, "aws_s3_bucket_name")

    @aws_s3_bucket_name.setter
    def aws_s3_bucket_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "aws_s3_bucket_name", value)

    @property
    @pulumi.getter(name="awsSecretAccessKey")
    def aws_secret_access_key(self) -> Optional[pulumi.Input[str]]:
        """
        Secret/Token of AWS S3 storage. Default Value: nil Required to create the Secret with the data to allow send the backup files to AWS S3 storage.
        """
        return pulumi.get(self, "aws_secret_access_key")

    @aws_secret_access_key.setter
    def aws_secret_access_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "aws_secret_access_key", value)

    @property
    @pulumi.getter(name="awsSecretName")
    def aws_secret_name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the secret with the AWS data credentials pre-existing in the cluster Default Value: nil See here the template: https://github.com/integr8ly/backup-container-image/blob/master/templates/openshift/sample-config/s3-secret.yaml 
        """
        return pulumi.get(self, "aws_secret_name")

    @aws_secret_name.setter
    def aws_secret_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "aws_secret_name", value)

    @property
    @pulumi.getter(name="awsSecretNamespace")
    def aws_secret_namespace(self) -> Optional[pulumi.Input[str]]:
        """
        Namespace of the secret with the AWS data credentials pre-existing in the cluster Default Value: nil NOTE: If the namespace be not informed then the operator will try to find it in the same namespace where it is applied 
        """
        return pulumi.get(self, "aws_secret_namespace")

    @aws_secret_namespace.setter
    def aws_secret_namespace(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "aws_secret_namespace", value)

    @property
    @pulumi.getter(name="databaseCRName")
    def database_cr_name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the Database CR applied which this backup will work with Default Value: database
        """
        return pulumi.get(self, "database_cr_name")

    @database_cr_name.setter
    def database_cr_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "database_cr_name", value)

    @property
    @pulumi.getter(name="databaseVersion")
    def database_version(self) -> Optional[pulumi.Input[str]]:
        """
        Database version. (E.g 9.6). Default Value: <9.6> IMPORTANT: Just the first 2 digits should be used.
        """
        return pulumi.get(self, "database_version")

    @database_version.setter
    def database_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "database_version", value)

    @property
    @pulumi.getter(name="encryptKeySecretName")
    def encrypt_key_secret_name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the secret with the Encrypt data pre-existing in the cluster Default Value: nil See here the template: https://github.com/integr8ly/backup-container-image/blob/master/templates/openshift/sample-config/gpg-secret.yaml
        """
        return pulumi.get(self, "encrypt_key_secret_name")

    @encrypt_key_secret_name.setter
    def encrypt_key_secret_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "encrypt_key_secret_name", value)

    @property
    @pulumi.getter(name="encryptKeySecretNamespace")
    def encrypt_key_secret_namespace(self) -> Optional[pulumi.Input[str]]:
        """
        Namespace of the secret with the Encrypt data pre-existing in the cluster Default Value: nil NOTE: If the namespace be not informed then the operator will try to find it in the same namespace where it is applied
        """
        return pulumi.get(self, "encrypt_key_secret_namespace")

    @encrypt_key_secret_namespace.setter
    def encrypt_key_secret_namespace(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "encrypt_key_secret_namespace", value)

    @property
    @pulumi.getter(name="gpgEmail")
    def gpg_email(self) -> Optional[pulumi.Input[str]]:
        """
        GPG email to create the EncryptionKeySecret with this data Default Value: nil See here how to create this key : https://help.github.com/en/articles/generating-a-new-gpg-key
        """
        return pulumi.get(self, "gpg_email")

    @gpg_email.setter
    def gpg_email(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "gpg_email", value)

    @property
    @pulumi.getter(name="gpgPublicKey")
    def gpg_public_key(self) -> Optional[pulumi.Input[str]]:
        """
        GPG public key to create the EncryptionKeySecret with this data Default Value: nil See here how to create this key : https://help.github.com/en/articles/generating-a-new-gpg-key
        """
        return pulumi.get(self, "gpg_public_key")

    @gpg_public_key.setter
    def gpg_public_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "gpg_public_key", value)

    @property
    @pulumi.getter(name="gpgTrustModel")
    def gpg_trust_model(self) -> Optional[pulumi.Input[str]]:
        """
        GPG trust model to create the EncryptionKeySecret with this data. the default value is true when it is empty. Default Value: nil See here how to create this key : https://help.github.com/en/articles/generating-a-new-gpg-key
        """
        return pulumi.get(self, "gpg_trust_model")

    @gpg_trust_model.setter
    def gpg_trust_model(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "gpg_trust_model", value)

    @property
    @pulumi.getter
    def image(self) -> Optional[pulumi.Input[str]]:
        """
        Image:tag used to do the backup. Default Value: <quay.io/integreatly/backup-container:1.0.8> More Info: https://github.com/integr8ly/backup-container-image
        """
        return pulumi.get(self, "image")

    @image.setter
    def image(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "image", value)

    @property
    @pulumi.getter(name="productName")
    def product_name(self) -> Optional[pulumi.Input[str]]:
        """
        Used to create the directory where the files will be stored Default Value: <postgresql> 
        """
        return pulumi.get(self, "product_name")

    @product_name.setter
    def product_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "product_name", value)

    @property
    @pulumi.getter
    def schedule(self) -> Optional[pulumi.Input[str]]:
        """
        Schedule period for the CronJob. Default Value: <0 0 * * *> daily at 00:00
        """
        return pulumi.get(self, "schedule")

    @schedule.setter
    def schedule(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "schedule", value)


@pulumi.input_type
class BackupStatusArgs:
    def __init__(__self__, *,
                 aws_credentials_secret_namespace: pulumi.Input[str],
                 aws_secret_name: pulumi.Input[str],
                 backup_status: pulumi.Input[str],
                 cron_job_name: pulumi.Input[str],
                 cron_job_status: pulumi.Input[Mapping[str, Any]],
                 db_secret_name: pulumi.Input[str],
                 encrypt_key_secret_name: pulumi.Input[str],
                 encrypt_key_secret_namespace: pulumi.Input[str],
                 has_encrypt_key: pulumi.Input[bool],
                 is_database_pod_found: pulumi.Input[bool],
                 is_database_service_found: pulumi.Input[bool]):
        """
        :param pulumi.Input[str] aws_credentials_secret_namespace: Namespace  of the secret object with the Aws data to allow send the backup files to the AWS storage
        :param pulumi.Input[str] aws_secret_name: Name  of the secret object with the Aws data to allow send the backup files to the AWS storage
        :param pulumi.Input[str] backup_status: Will be as "OK when all objects are created successfully
        :param pulumi.Input[str] cron_job_name: Name of the CronJob object created and managed by it to schedule the backup job
        :param pulumi.Input[Mapping[str, Any]] cron_job_status: Status of the CronJob object
        :param pulumi.Input[str] db_secret_name: Name of the secret object created with the database data to allow the backup image connect to the database
        :param pulumi.Input[str] encrypt_key_secret_name: Name  of the secret object with the Encryption GPG Key
        :param pulumi.Input[str] encrypt_key_secret_namespace: Namespace of the secret object with the Encryption GPG Key
        :param pulumi.Input[bool] has_encrypt_key: Boolean value which has true when it has an EncryptionKey to be used to send the backup files
        :param pulumi.Input[bool] is_database_pod_found: Boolean value which has true when the Database Pod was found in order to create the secret with the database data to allow the backup image connect into it. 
        :param pulumi.Input[bool] is_database_service_found: Boolean value which has true when the Service Database Pod was found in order to create the secret with the database data to allow the backup image connect into it.
        """
        pulumi.set(__self__, "aws_credentials_secret_namespace", aws_credentials_secret_namespace)
        pulumi.set(__self__, "aws_secret_name", aws_secret_name)
        pulumi.set(__self__, "backup_status", backup_status)
        pulumi.set(__self__, "cron_job_name", cron_job_name)
        pulumi.set(__self__, "cron_job_status", cron_job_status)
        pulumi.set(__self__, "db_secret_name", db_secret_name)
        pulumi.set(__self__, "encrypt_key_secret_name", encrypt_key_secret_name)
        pulumi.set(__self__, "encrypt_key_secret_namespace", encrypt_key_secret_namespace)
        pulumi.set(__self__, "has_encrypt_key", has_encrypt_key)
        pulumi.set(__self__, "is_database_pod_found", is_database_pod_found)
        pulumi.set(__self__, "is_database_service_found", is_database_service_found)

    @property
    @pulumi.getter(name="awsCredentialsSecretNamespace")
    def aws_credentials_secret_namespace(self) -> pulumi.Input[str]:
        """
        Namespace  of the secret object with the Aws data to allow send the backup files to the AWS storage
        """
        return pulumi.get(self, "aws_credentials_secret_namespace")

    @aws_credentials_secret_namespace.setter
    def aws_credentials_secret_namespace(self, value: pulumi.Input[str]):
        pulumi.set(self, "aws_credentials_secret_namespace", value)

    @property
    @pulumi.getter(name="awsSecretName")
    def aws_secret_name(self) -> pulumi.Input[str]:
        """
        Name  of the secret object with the Aws data to allow send the backup files to the AWS storage
        """
        return pulumi.get(self, "aws_secret_name")

    @aws_secret_name.setter
    def aws_secret_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "aws_secret_name", value)

    @property
    @pulumi.getter(name="backupStatus")
    def backup_status(self) -> pulumi.Input[str]:
        """
        Will be as "OK when all objects are created successfully
        """
        return pulumi.get(self, "backup_status")

    @backup_status.setter
    def backup_status(self, value: pulumi.Input[str]):
        pulumi.set(self, "backup_status", value)

    @property
    @pulumi.getter(name="cronJobName")
    def cron_job_name(self) -> pulumi.Input[str]:
        """
        Name of the CronJob object created and managed by it to schedule the backup job
        """
        return pulumi.get(self, "cron_job_name")

    @cron_job_name.setter
    def cron_job_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "cron_job_name", value)

    @property
    @pulumi.getter(name="cronJobStatus")
    def cron_job_status(self) -> pulumi.Input[Mapping[str, Any]]:
        """
        Status of the CronJob object
        """
        return pulumi.get(self, "cron_job_status")

    @cron_job_status.setter
    def cron_job_status(self, value: pulumi.Input[Mapping[str, Any]]):
        pulumi.set(self, "cron_job_status", value)

    @property
    @pulumi.getter(name="dbSecretName")
    def db_secret_name(self) -> pulumi.Input[str]:
        """
        Name of the secret object created with the database data to allow the backup image connect to the database
        """
        return pulumi.get(self, "db_secret_name")

    @db_secret_name.setter
    def db_secret_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "db_secret_name", value)

    @property
    @pulumi.getter(name="encryptKeySecretName")
    def encrypt_key_secret_name(self) -> pulumi.Input[str]:
        """
        Name  of the secret object with the Encryption GPG Key
        """
        return pulumi.get(self, "encrypt_key_secret_name")

    @encrypt_key_secret_name.setter
    def encrypt_key_secret_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "encrypt_key_secret_name", value)

    @property
    @pulumi.getter(name="encryptKeySecretNamespace")
    def encrypt_key_secret_namespace(self) -> pulumi.Input[str]:
        """
        Namespace of the secret object with the Encryption GPG Key
        """
        return pulumi.get(self, "encrypt_key_secret_namespace")

    @encrypt_key_secret_namespace.setter
    def encrypt_key_secret_namespace(self, value: pulumi.Input[str]):
        pulumi.set(self, "encrypt_key_secret_namespace", value)

    @property
    @pulumi.getter(name="hasEncryptKey")
    def has_encrypt_key(self) -> pulumi.Input[bool]:
        """
        Boolean value which has true when it has an EncryptionKey to be used to send the backup files
        """
        return pulumi.get(self, "has_encrypt_key")

    @has_encrypt_key.setter
    def has_encrypt_key(self, value: pulumi.Input[bool]):
        pulumi.set(self, "has_encrypt_key", value)

    @property
    @pulumi.getter(name="isDatabasePodFound")
    def is_database_pod_found(self) -> pulumi.Input[bool]:
        """
        Boolean value which has true when the Database Pod was found in order to create the secret with the database data to allow the backup image connect into it. 
        """
        return pulumi.get(self, "is_database_pod_found")

    @is_database_pod_found.setter
    def is_database_pod_found(self, value: pulumi.Input[bool]):
        pulumi.set(self, "is_database_pod_found", value)

    @property
    @pulumi.getter(name="isDatabaseServiceFound")
    def is_database_service_found(self) -> pulumi.Input[bool]:
        """
        Boolean value which has true when the Service Database Pod was found in order to create the secret with the database data to allow the backup image connect into it.
        """
        return pulumi.get(self, "is_database_service_found")

    @is_database_service_found.setter
    def is_database_service_found(self, value: pulumi.Input[bool]):
        pulumi.set(self, "is_database_service_found", value)

