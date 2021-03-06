/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSMBFileShare operation.
    /// Creates a Server Message Block (SMB) file share on an existing file gateway. In Storage
    /// Gateway, a file share is a file system mount point backed by Amazon S3 cloud storage.
    /// Storage Gateway expose file shares using a SMB interface. This operation is only supported
    /// in the file gateway type.
    /// 
    ///  <important> 
    /// <para>
    /// File gateway requires AWS Security Token Service (AWS STS) to be activated to enable
    /// you create a file share. Make sure AWS STS is activated in the region you are creating
    /// your file gateway in. If AWS STS is not activated in the region, activate it. For
    /// information about how to activate AWS STS, see Activating and Deactivating AWS STS
    /// in an AWS Region in the AWS Identity and Access Management User Guide. 
    /// </para>
    ///  
    /// <para>
    /// File gateway does not support creating hard or symbolic links on a file share.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateSMBFileShareRequest : AmazonStorageGatewayRequest
    {
        private string _authentication;
        private string _clientToken;
        private string _defaultStorageClass;
        private string _gatewayARN;
        private bool? _guessMIMETypeEnabled;
        private List<string> _invalidUserList = new List<string>();
        private bool? _kmsEncrypted;
        private string _kmsKey;
        private string _locationARN;
        private ObjectACL _objectACL;
        private bool? _readOnly;
        private bool? _requesterPays;
        private string _role;
        private List<string> _validUserList = new List<string>();

        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// The authentication method that users use to access the file share.
        /// </para>
        ///  
        /// <para>
        /// Valid values: "ActiveDirectory" or "GuestAccess". The default is "ActiveDirectory".
        /// </para>
        /// </summary>
        public string Authentication
        {
            get { return this._authentication; }
            set { this._authentication = value; }
        }

        // Check to see if Authentication property is set
        internal bool IsSetAuthentication()
        {
            return this._authentication != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique string value that you supply that is used by file gateway to ensure idempotent
        /// file share creation.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultStorageClass. 
        /// <para>
        /// The default storage class for objects put into an Amazon S3 bucket by file gateway.
        /// Possible values are S3_STANDARD, S3_STANDARD_IA or S3_ONEZONE_IA. If this field is
        /// not populated, the default value S3_STANDARD is used. Optional.
        /// </para>
        /// </summary>
        public string DefaultStorageClass
        {
            get { return this._defaultStorageClass; }
            set { this._defaultStorageClass = value; }
        }

        // Check to see if DefaultStorageClass property is set
        internal bool IsSetDefaultStorageClass()
        {
            return this._defaultStorageClass != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the file gateway on which you want to create a file
        /// share.
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property GuessMIMETypeEnabled. 
        /// <para>
        /// Enables guessing of the MIME type for uploaded objects based on file extensions. Set
        /// this value to true to enable MIME type guessing, and otherwise to false. The default
        /// value is true.
        /// </para>
        /// </summary>
        public bool GuessMIMETypeEnabled
        {
            get { return this._guessMIMETypeEnabled.GetValueOrDefault(); }
            set { this._guessMIMETypeEnabled = value; }
        }

        // Check to see if GuessMIMETypeEnabled property is set
        internal bool IsSetGuessMIMETypeEnabled()
        {
            return this._guessMIMETypeEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InvalidUserList. 
        /// <para>
        /// A list of users in the Active Directory that are not allowed to access the file share.
        /// Can only be set if Authentication is set to "ActiveDirectory".
        /// </para>
        /// </summary>
        public List<string> InvalidUserList
        {
            get { return this._invalidUserList; }
            set { this._invalidUserList = value; }
        }

        // Check to see if InvalidUserList property is set
        internal bool IsSetInvalidUserList()
        {
            return this._invalidUserList != null && this._invalidUserList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KMSEncrypted. 
        /// <para>
        /// True to use Amazon S3 server side encryption with your own AWS KMS key, or false to
        /// use a key managed by Amazon S3. Optional.
        /// </para>
        /// </summary>
        public bool KMSEncrypted
        {
            get { return this._kmsEncrypted.GetValueOrDefault(); }
            set { this._kmsEncrypted = value; }
        }

        // Check to see if KMSEncrypted property is set
        internal bool IsSetKMSEncrypted()
        {
            return this._kmsEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSKey. 
        /// <para>
        /// The Amazon Resource Name (ARN) KMS key used for Amazon S3 server side encryption.
        /// This value can only be set when KMSEncrypted is true. Optional.
        /// </para>
        /// </summary>
        public string KMSKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KMSKey property is set
        internal bool IsSetKMSKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property LocationARN. 
        /// <para>
        /// The ARN of the backed storage used for storing file data. 
        /// </para>
        /// </summary>
        public string LocationARN
        {
            get { return this._locationARN; }
            set { this._locationARN = value; }
        }

        // Check to see if LocationARN property is set
        internal bool IsSetLocationARN()
        {
            return this._locationARN != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectACL. 
        /// <para>
        /// Sets the access control list permission for objects in the Amazon S3 bucket that a
        /// file gateway puts objects into. The default value is "private".
        /// </para>
        /// </summary>
        public ObjectACL ObjectACL
        {
            get { return this._objectACL; }
            set { this._objectACL = value; }
        }

        // Check to see if ObjectACL property is set
        internal bool IsSetObjectACL()
        {
            return this._objectACL != null;
        }

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// Sets the write status of a file share. This value is true if the write status is read-only,
        /// and otherwise false.
        /// </para>
        /// </summary>
        public bool ReadOnly
        {
            get { return this._readOnly.GetValueOrDefault(); }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequesterPays. 
        /// <para>
        /// Sets who pays the cost of the request and the data download from the Amazon S3 bucket.
        /// Set this value to true if you want the requester to pay instead of the bucket owner,
        /// and otherwise to false.
        /// </para>
        /// </summary>
        public bool RequesterPays
        {
            get { return this._requesterPays.GetValueOrDefault(); }
            set { this._requesterPays = value; }
        }

        // Check to see if RequesterPays property is set
        internal bool IsSetRequesterPays()
        {
            return this._requesterPays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The ARN of the AWS Identity and Access Management (IAM) role that a file gateway assumes
        /// when it accesses the underlying storage. 
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property ValidUserList. 
        /// <para>
        /// A list of users in the Active Directory that are allowed to access the file share.
        /// Can only be set if Authentication is set to "ActiveDirectory".
        /// </para>
        /// </summary>
        public List<string> ValidUserList
        {
            get { return this._validUserList; }
            set { this._validUserList = value; }
        }

        // Check to see if ValidUserList property is set
        internal bool IsSetValidUserList()
        {
            return this._validUserList != null && this._validUserList.Count > 0; 
        }

    }
}