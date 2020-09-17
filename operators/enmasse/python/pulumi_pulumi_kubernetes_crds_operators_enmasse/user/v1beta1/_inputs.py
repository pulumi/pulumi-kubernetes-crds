# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'MessagingUserSpecArgs',
    'MessagingUserSpecAuthenticationArgs',
    'MessagingUserSpecAuthorizationArgs',
    'MessagingUserStatusArgs',
]

@pulumi.input_type
class MessagingUserSpecArgs:
    def __init__(__self__, *,
                 authentication: pulumi.Input['MessagingUserSpecAuthenticationArgs'],
                 username: pulumi.Input[str],
                 authorization: Optional[pulumi.Input[Sequence[pulumi.Input['MessagingUserSpecAuthorizationArgs']]]] = None):
        """
        :param pulumi.Input['MessagingUserSpecAuthenticationArgs'] authentication: The authentication specification.
        :param pulumi.Input[str] username: The username used by messaging clients.
        :param pulumi.Input[Sequence[pulumi.Input['MessagingUserSpecAuthorizationArgs']]] authorization: The authorization rules for the user.
        """
        pulumi.set(__self__, "authentication", authentication)
        pulumi.set(__self__, "username", username)
        if authorization is not None:
            pulumi.set(__self__, "authorization", authorization)

    @property
    @pulumi.getter
    def authentication(self) -> pulumi.Input['MessagingUserSpecAuthenticationArgs']:
        """
        The authentication specification.
        """
        return pulumi.get(self, "authentication")

    @authentication.setter
    def authentication(self, value: pulumi.Input['MessagingUserSpecAuthenticationArgs']):
        pulumi.set(self, "authentication", value)

    @property
    @pulumi.getter
    def username(self) -> pulumi.Input[str]:
        """
        The username used by messaging clients.
        """
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: pulumi.Input[str]):
        pulumi.set(self, "username", value)

    @property
    @pulumi.getter
    def authorization(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MessagingUserSpecAuthorizationArgs']]]]:
        """
        The authorization rules for the user.
        """
        return pulumi.get(self, "authorization")

    @authorization.setter
    def authorization(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MessagingUserSpecAuthorizationArgs']]]]):
        pulumi.set(self, "authorization", value)


@pulumi.input_type
class MessagingUserSpecAuthenticationArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[str],
                 federated_userid: Optional[pulumi.Input[str]] = None,
                 federated_username: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 provider: Optional[pulumi.Input[str]] = None):
        """
        The authentication specification.
        :param pulumi.Input[str] type: The type of authentication.
        :param pulumi.Input[str] federated_userid: Federated user id for the 'federated' authentication type.
        :param pulumi.Input[str] federated_username: Federated user name for the 'federated' authentication type.
        :param pulumi.Input[str] password: Base64-encoded password for the 'password' authentication type.
        :param pulumi.Input[str] provider: Federated identity provider for the 'federated' authentication type.
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
    def type(self) -> pulumi.Input[str]:
        """
        The type of authentication.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="federatedUserid")
    def federated_userid(self) -> Optional[pulumi.Input[str]]:
        """
        Federated user id for the 'federated' authentication type.
        """
        return pulumi.get(self, "federated_userid")

    @federated_userid.setter
    def federated_userid(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "federated_userid", value)

    @property
    @pulumi.getter(name="federatedUsername")
    def federated_username(self) -> Optional[pulumi.Input[str]]:
        """
        Federated user name for the 'federated' authentication type.
        """
        return pulumi.get(self, "federated_username")

    @federated_username.setter
    def federated_username(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "federated_username", value)

    @property
    @pulumi.getter
    def password(self) -> Optional[pulumi.Input[str]]:
        """
        Base64-encoded password for the 'password' authentication type.
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def provider(self) -> Optional[pulumi.Input[str]]:
        """
        Federated identity provider for the 'federated' authentication type.
        """
        return pulumi.get(self, "provider")

    @provider.setter
    def provider(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "provider", value)


@pulumi.input_type
class MessagingUserSpecAuthorizationArgs:
    def __init__(__self__, *,
                 addresses: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 operations: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        :param pulumi.Input[Sequence[pulumi.Input[str]]] addresses: The addresses the rule should apply to.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] operations: The operations that should apply to addresses matched by this rule.
        """
        if addresses is not None:
            pulumi.set(__self__, "addresses", addresses)
        if operations is not None:
            pulumi.set(__self__, "operations", operations)

    @property
    @pulumi.getter
    def addresses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The addresses the rule should apply to.
        """
        return pulumi.get(self, "addresses")

    @addresses.setter
    def addresses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "addresses", value)

    @property
    @pulumi.getter
    def operations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The operations that should apply to addresses matched by this rule.
        """
        return pulumi.get(self, "operations")

    @operations.setter
    def operations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "operations", value)


@pulumi.input_type
class MessagingUserStatusArgs:
    def __init__(__self__, *,
                 generation: Optional[pulumi.Input[int]] = None,
                 message: Optional[pulumi.Input[str]] = None,
                 phase: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[int] generation: Applied generation
        :param pulumi.Input[str] message: Message describing the current state
        :param pulumi.Input[str] phase: The lifecycle phase of the messaging user
        """
        if generation is not None:
            pulumi.set(__self__, "generation", generation)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if phase is not None:
            pulumi.set(__self__, "phase", phase)

    @property
    @pulumi.getter
    def generation(self) -> Optional[pulumi.Input[int]]:
        """
        Applied generation
        """
        return pulumi.get(self, "generation")

    @generation.setter
    def generation(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "generation", value)

    @property
    @pulumi.getter
    def message(self) -> Optional[pulumi.Input[str]]:
        """
        Message describing the current state
        """
        return pulumi.get(self, "message")

    @message.setter
    def message(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "message", value)

    @property
    @pulumi.getter
    def phase(self) -> Optional[pulumi.Input[str]]:
        """
        The lifecycle phase of the messaging user
        """
        return pulumi.get(self, "phase")

    @phase.setter
    def phase(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "phase", value)


