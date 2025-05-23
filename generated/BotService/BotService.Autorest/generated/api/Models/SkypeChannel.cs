// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Extensions;

    /// <summary>Skype channel definition</summary>
    public partial class SkypeChannel :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannel,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannel" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannel __channel = new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Channel();

        /// <summary>Calling web hook for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string CallingWebHook { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).CallingWebHook; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).CallingWebHook = value ?? null; }

        /// <summary>Enable calling for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public bool? EnableCalling { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableCalling; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableCalling = value ?? default(bool); }

        /// <summary>Enable groups for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public bool? EnableGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableGroup = value ?? default(bool); }

        /// <summary>Enable media cards for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public bool? EnableMediaCard { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableMediaCard; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableMediaCard = value ?? default(bool); }

        /// <summary>Enable messaging for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public bool? EnableMessaging { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableMessaging; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableMessaging = value ?? default(bool); }

        /// <summary>Enable screen sharing for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public bool? EnableScreenSharing { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableScreenSharing; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableScreenSharing = value ?? default(bool); }

        /// <summary>Enable video for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public bool? EnableVideo { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableVideo; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).EnableVideo = value ?? default(bool); }

        /// <summary>Entity Tag of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)__channel).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)__channel).Etag = value ?? null; }

        /// <summary>Group mode for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string GroupsMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).GroupsMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).GroupsMode = value ?? null; }

        /// <summary>Incoming call route for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string IncomingCallRoute { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).IncomingCallRoute; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).IncomingCallRoute = value ?? null; }

        /// <summary>Whether this channel is enabled for the bot</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public bool? IsEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).IsEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelPropertiesInternal)Property).IsEnabled = value ?? default(bool); }

        /// <summary>Specifies the location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)__channel).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)__channel).Location = value ?? null; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)__channel).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)__channel).ProvisioningState = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelProperties Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.SkypeChannelProperties()); set { {_property = value;} } }

        /// <summary>The channel name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Name { get => "SkypeChannel"; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)__channel).Name = "SkypeChannel"; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelProperties _property;

        /// <summary>The set of properties specific to Skype channel resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.SkypeChannelProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal)__channel).ProvisioningState; }

        /// <summary>Creates an new <see cref="SkypeChannel" /> instance.</summary>
        public SkypeChannel()
        {
            this.__channel.Name = "SkypeChannel";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__channel), __channel);
            await eventListener.AssertObjectIsValid(nameof(__channel), __channel);
        }
    }
    /// Skype channel definition
    public partial interface ISkypeChannel :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannel
    {
        /// <summary>Calling web hook for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Calling web hook for Skype channel",
        SerializedName = @"callingWebHook",
        PossibleTypes = new [] { typeof(string) })]
        string CallingWebHook { get; set; }
        /// <summary>Enable calling for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable calling for Skype channel",
        SerializedName = @"enableCalling",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableCalling { get; set; }
        /// <summary>Enable groups for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable groups for Skype channel",
        SerializedName = @"enableGroups",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableGroup { get; set; }
        /// <summary>Enable media cards for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable media cards for Skype channel",
        SerializedName = @"enableMediaCards",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableMediaCard { get; set; }
        /// <summary>Enable messaging for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable messaging for Skype channel",
        SerializedName = @"enableMessaging",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableMessaging { get; set; }
        /// <summary>Enable screen sharing for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable screen sharing for Skype channel",
        SerializedName = @"enableScreenSharing",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableScreenSharing { get; set; }
        /// <summary>Enable video for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable video for Skype channel",
        SerializedName = @"enableVideo",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableVideo { get; set; }
        /// <summary>Group mode for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Group mode for Skype channel",
        SerializedName = @"groupsMode",
        PossibleTypes = new [] { typeof(string) })]
        string GroupsMode { get; set; }
        /// <summary>Incoming call route for Skype channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Incoming call route for Skype channel",
        SerializedName = @"incomingCallRoute",
        PossibleTypes = new [] { typeof(string) })]
        string IncomingCallRoute { get; set; }
        /// <summary>Whether this channel is enabled for the bot</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this channel is enabled for the bot",
        SerializedName = @"isEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsEnabled { get; set; }

    }
    /// Skype channel definition
    internal partial interface ISkypeChannelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IChannelInternal
    {
        /// <summary>Calling web hook for Skype channel</summary>
        string CallingWebHook { get; set; }
        /// <summary>Enable calling for Skype channel</summary>
        bool? EnableCalling { get; set; }
        /// <summary>Enable groups for Skype channel</summary>
        bool? EnableGroup { get; set; }
        /// <summary>Enable media cards for Skype channel</summary>
        bool? EnableMediaCard { get; set; }
        /// <summary>Enable messaging for Skype channel</summary>
        bool? EnableMessaging { get; set; }
        /// <summary>Enable screen sharing for Skype channel</summary>
        bool? EnableScreenSharing { get; set; }
        /// <summary>Enable video for Skype channel</summary>
        bool? EnableVideo { get; set; }
        /// <summary>Group mode for Skype channel</summary>
        string GroupsMode { get; set; }
        /// <summary>Incoming call route for Skype channel</summary>
        string IncomingCallRoute { get; set; }
        /// <summary>Whether this channel is enabled for the bot</summary>
        bool? IsEnabled { get; set; }
        /// <summary>The set of properties specific to Skype channel resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISkypeChannelProperties Property { get; set; }

    }
}