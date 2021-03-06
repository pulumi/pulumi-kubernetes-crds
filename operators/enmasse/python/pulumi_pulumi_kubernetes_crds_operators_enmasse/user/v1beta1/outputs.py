# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs

__all__ = [
    'MessagingUserSpec',
    'MessagingUserSpecAuthentication',
    'MessagingUserSpecAuthorization',
    'MessagingUserStatus',
]

@pulumi.output_type
class MessagingUserSpec(dict):
    def __init__(__self__, *,
                 authentication: 'outputs.MessagingUserSpecAuthentication',
                 username: str,
                 authorization: Optional[Sequence['outputs.MessagingUserSpecAuthorization']] = None):
        """
        :param 'MessagingUserSpecAuthenticationArgs' authentication: The authentication specification.
        :param str username: The username used by messaging clients.
        :param Sequence['MessagingUserSpecAuthorizationArgs'] authorization: The authorization rules for the user.
        """
        pulumi.set(__self__, "authentication", authentication)
        pulumi.set(__self__, "username", username)
        if authorization is not None:
            pulumi.set(__self__, "authorization", authorization)

    @property
    @pulumi.getter
    def authentication(self) -> 'outputs.MessagingUserSpecAuthentication':
        """
        The authentication specification.
        """
        return pulumi.get(self, "authentication")

    @property
    @pulumi.getter
    def username(self) -> str:
        """
        The username used by messaging clients.
        """
        return pulumi.get(self, "username")

    @property
    @pulumi.getter
    def authorization(self) -> Optional[Sequence['outputs.MessagingUserSpecAuthorization']]:
        """
        The authorization rules for the user.
        """
        return pulumi.get(self, "authorization")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class MessagingUserSpecAuthentication(dict):
    """
    The authentication specification.
    """
    def __init__(__self__, *,
                 type: str,
                 federated_userid: Optional[str] = None,
                 federated_username: Optional[str] = None,
                 password: Optional[str] = None,
                 provider: Optional[str] = None):
        """
        The authentication specification.
        :param str type: The type of authentication.
        :param str federated_userid: Federated user id for the 'federated' authentication type.
        :param str federated_username: Federated user name for the 'federated' authentication type.
        :param str password: Base64-encoded password for the 'password' authentication type.
        :param str provider: Federated identity provider for the 'federated' authentication type.
        """
        pulumi.set(__self__, "type", type)
        if federated_userid is not None:
            pulumi.set(__self__, "federated_userid", federated_userid)
        if federated_username is not None:
            pulumi.set(__self__, "federated_username", federated_username)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if provider is not None:
            pulumi.set(__self__, "provider", provider)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        The type of authentication.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="federatedUserid")
    def federated_userid(self) -> Optional[str]:
        """
        Federated user id for the 'federated' authentication type.
        """
        return pulumi.get(self, "federated_userid")

    @property
    @pulumi.getter(name="federatedUsername")
    def federated_username(self) -> Optional[str]:
        """
        Federated user name for the 'federated' authentication type.
        """
        return pulumi.get(self, "federated_username")

    @property
    @pulumi.getter
    def password(self) -> Optional[str]:
        """
        Base64-encoded password for the 'password' authentication type.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def provider(self) -> Optional[str]:
        """
        Federated identity provider for the 'federated' authentication type.
        """
        return pulumi.get(self, "provider")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class MessagingUserSpecAuthorization(dict):
    def __init__(__self__, *,
                 addresses: Optional[Sequence[str]] = None,
                 operations: Optional[Sequence[str]] = None):
        """
        :param Sequence[str] addresses: The addresses the rule should apply to.
        :param Sequence[str] operations: The operations that should apply to addresses matched by this rule.
        """
        if addresses is not None:
            pulumi.set(__self__, "addresses", addresses)
        if operations is not None:
            pulumi.set(__self__, "operations", operations)

    @property
    @pulumi.getter
    def addresses(self) -> Optional[Sequence[str]]:
        """
        The addresses the rule should apply to.
        """
        return pulumi.get(self, "addresses")

    @property
    @pulumi.getter
    def operations(self) -> Optional[Sequence[str]]:
        """
        The operations that should apply to addresses matched by this rule.
        """
        return pulumi.get(self, "operations")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class MessagingUserStatus(dict):
    def __init__(__self__, *,
                 generation: Optional[int] = None,
                 message: Optional[str] = None,
                 phase: Optional[str] = None):
        """
        :param int generation: Applied generation
        :param str message: Message describing the current state
        :param str phase: The lifecycle phase of the messaging user
        """
        if generation is not None:
            pulumi.set(__self__, "generation", generation)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if phase is not None:
            pulumi.set(__self__, "phase", phase)

    @property
    @pulumi.getter
    def generation(self) -> Optional[int]:
        """
        Applied generation
        """
        return pulumi.get(self, "generation")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        """
        Message describing the current state
        """
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def phase(self) -> Optional[str]:
        """
        The lifecycle phase of the messaging user
        """
        return pulumi.get(self, "phase")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


