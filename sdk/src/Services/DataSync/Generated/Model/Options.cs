/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Represents the options that are available to control the behavior of a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_StartTaskExecution.html">StartTaskExecution</a>
    /// operation. Behavior includes preserving metadata such as user ID (UID), group ID (GID),
    /// and file permissions, and also overwriting files in the destination, data integrity
    /// verification, and so on.
    /// 
    ///  
    /// <para>
    /// A task has a set of default options associated with it. If you don't specify an option
    /// in <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_StartTaskExecution.html">StartTaskExecution</a>,
    /// the default value is used. You can override the defaults options on each task execution
    /// by specifying an overriding <code>Options</code> value to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_StartTaskExecution.html">StartTaskExecution</a>.
    /// </para>
    /// </summary>
    public partial class Options
    {
        private Atime _atime;
        private long? _bytesPerSecond;
        private Gid _gid;
        private LogLevel _logLevel;
        private Mtime _mtime;
        private ObjectTags _objectTags;
        private OverwriteMode _overwriteMode;
        private PosixPermissions _posixPermissions;
        private PreserveDeletedFiles _preserveDeletedFiles;
        private PreserveDevices _preserveDevices;
        private SmbSecurityDescriptorCopyFlags _securityDescriptorCopyFlags;
        private TaskQueueing _taskQueueing;
        private TransferMode _transferMode;
        private Uid _uid;
        private VerifyMode _verifyMode;

        /// <summary>
        /// Gets and sets the property Atime. 
        /// <para>
        /// A file metadata value that shows the last time a file was accessed (that is, when
        /// the file was read or written to). If you set <code>Atime</code> to <code>BEST_EFFORT</code>,
        /// DataSync attempts to preserve the original <code>Atime</code> attribute on all source
        /// files (that is, the version before the <code>PREPARING</code> phase). However, <code>Atime</code>'s
        /// behavior is not fully standard across platforms, so DataSync can only do this on a
        /// best-effort basis. 
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>BEST_EFFORT</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>BEST_EFFORT</code>: Attempt to preserve the per-file <code>Atime</code> value
        /// (recommended).
        /// </para>
        ///  
        /// <para>
        ///  <code>NONE</code>: Ignore <code>Atime</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>Atime</code> is set to <code>BEST_EFFORT</code>, <code>Mtime</code> must
        /// be set to <code>PRESERVE</code>. 
        /// </para>
        ///  
        /// <para>
        /// If <code>Atime</code> is set to <code>NONE</code>, <code>Mtime</code> must also be
        /// <code>NONE</code>. 
        /// </para>
        ///  </note>
        /// </summary>
        public Atime Atime
        {
            get { return this._atime; }
            set { this._atime = value; }
        }

        // Check to see if Atime property is set
        internal bool IsSetAtime()
        {
            return this._atime != null;
        }

        /// <summary>
        /// Gets and sets the property BytesPerSecond. 
        /// <para>
        /// A value that limits the bandwidth used by DataSync. For example, if you want DataSync
        /// to use a maximum of 1 MB, set this value to <code>1048576</code> (<code>=1024*1024</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1)]
        public long BytesPerSecond
        {
            get { return this._bytesPerSecond.GetValueOrDefault(); }
            set { this._bytesPerSecond = value; }
        }

        // Check to see if BytesPerSecond property is set
        internal bool IsSetBytesPerSecond()
        {
            return this._bytesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Gid. 
        /// <para>
        /// The POSIX group ID (GID) of the file's owners.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/special-files.html#metadata-copied">Metadata
        /// copied by DataSync</a>.
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>INT_VALUE</code>. This preserves the integer value of the ID.
        /// </para>
        ///  
        /// <para>
        ///  <code>INT_VALUE</code>: Preserve the integer value of user ID (UID) and GID (recommended).
        /// </para>
        ///  
        /// <para>
        ///  <code>NONE</code>: Ignore UID and GID.
        /// </para>
        /// </summary>
        public Gid Gid
        {
            get { return this._gid; }
            set { this._gid = value; }
        }

        // Check to see if Gid property is set
        internal bool IsSetGid()
        {
            return this._gid != null;
        }

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// A value that determines the type of logs that DataSync publishes to a log stream in
        /// the Amazon CloudWatch log group that you provide. For more information about providing
        /// a log group for DataSync, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_CreateTask.html#DataSync-CreateTask-request-CloudWatchLogGroupArn">CloudWatchLogGroupArn</a>.
        /// If set to <code>OFF</code>, no logs are published. <code>BASIC</code> publishes logs
        /// on errors for individual files transferred, and <code>TRANSFER</code> publishes logs
        /// for every file or object that is transferred and integrity checked.
        /// </para>
        /// </summary>
        public LogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Mtime. 
        /// <para>
        /// A value that indicates the last time that a file was modified (that is, a file was
        /// written to) before the <code>PREPARING</code> phase. This option is required for cases
        /// when you need to run the same task more than one time. 
        /// </para>
        ///  
        /// <para>
        /// Default Value: <code>PRESERVE</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>PRESERVE</code>: Preserve original <code>Mtime</code> (recommended)
        /// </para>
        ///  
        /// <para>
        ///  <code>NONE</code>: Ignore <code>Mtime</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <code>Mtime</code> is set to <code>PRESERVE</code>, <code>Atime</code> must be
        /// set to <code>BEST_EFFORT</code>.
        /// </para>
        ///  
        /// <para>
        /// If <code>Mtime</code> is set to <code>NONE</code>, <code>Atime</code> must also be
        /// set to <code>NONE</code>. 
        /// </para>
        ///  </note>
        /// </summary>
        public Mtime Mtime
        {
            get { return this._mtime; }
            set { this._mtime = value; }
        }

        // Check to see if Mtime property is set
        internal bool IsSetMtime()
        {
            return this._mtime != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectTags. 
        /// <para>
        /// Specifies whether object tags are maintained when transferring between object storage
        /// systems. If you want your DataSync task to ignore object tags, specify the <code>NONE</code>
        /// value.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <code>PRESERVE</code> 
        /// </para>
        /// </summary>
        public ObjectTags ObjectTags
        {
            get { return this._objectTags; }
            set { this._objectTags = value; }
        }

        // Check to see if ObjectTags property is set
        internal bool IsSetObjectTags()
        {
            return this._objectTags != null;
        }

        /// <summary>
        /// Gets and sets the property OverwriteMode. 
        /// <para>
        /// A value that determines whether files at the destination should be overwritten or
        /// preserved when copying files. If set to <code>NEVER</code> a destination file will
        /// not be replaced by a source file, even if the destination file differs from the source
        /// file. If you modify files in the destination and you sync the files, you can use this
        /// value to protect against overwriting those changes. 
        /// </para>
        ///  
        /// <para>
        /// Some storage classes have specific behaviors that can affect your S3 storage cost.
        /// For detailed information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Considerations
        /// when working with Amazon S3 storage classes in DataSync </a> in the <i>DataSync User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public OverwriteMode OverwriteMode
        {
            get { return this._overwriteMode; }
            set { this._overwriteMode = value; }
        }

        // Check to see if OverwriteMode property is set
        internal bool IsSetOverwriteMode()
        {
            return this._overwriteMode != null;
        }

        /// <summary>
        /// Gets and sets the property PosixPermissions. 
        /// <para>
        /// A value that determines which users or groups can access a file for a specific purpose
        /// such as reading, writing, or execution of the file.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/special-files.html#metadata-copied">Metadata
        /// copied by DataSync</a>.
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>PRESERVE</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>PRESERVE</code>: Preserve POSIX-style permissions (recommended).
        /// </para>
        ///  
        /// <para>
        ///  <code>NONE</code>: Ignore permissions. 
        /// </para>
        ///  <note> 
        /// <para>
        /// DataSync can preserve extant permissions of a source location.
        /// </para>
        ///  </note>
        /// </summary>
        public PosixPermissions PosixPermissions
        {
            get { return this._posixPermissions; }
            set { this._posixPermissions = value; }
        }

        // Check to see if PosixPermissions property is set
        internal bool IsSetPosixPermissions()
        {
            return this._posixPermissions != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveDeletedFiles. 
        /// <para>
        /// A value that specifies whether files in the destination that don't exist in the source
        /// file system should be preserved. This option can affect your storage cost. If your
        /// task deletes objects, you might incur minimum storage duration charges for certain
        /// storage classes. For detailed information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Considerations
        /// when working with Amazon S3 storage classes in DataSync </a> in the <i>DataSync User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>PRESERVE</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>PRESERVE</code>: Ignore such destination files (recommended). 
        /// </para>
        ///  
        /// <para>
        ///  <code>REMOVE</code>: Delete destination files that aren’t present in the source.
        /// </para>
        /// </summary>
        public PreserveDeletedFiles PreserveDeletedFiles
        {
            get { return this._preserveDeletedFiles; }
            set { this._preserveDeletedFiles = value; }
        }

        // Check to see if PreserveDeletedFiles property is set
        internal bool IsSetPreserveDeletedFiles()
        {
            return this._preserveDeletedFiles != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveDevices. 
        /// <para>
        /// A value that determines whether DataSync should preserve the metadata of block and
        /// character devices in the source file system, and re-create the files with that device
        /// name and metadata on the destination. DataSync does not copy the contents of such
        /// devices, only the name and metadata. 
        /// </para>
        ///  <note> 
        /// <para>
        /// DataSync can't sync the actual contents of such devices, because they are nonterminal
        /// and don't return an end-of-file (EOF) marker.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default value: <code>NONE</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>NONE</code>: Ignore special devices (recommended). 
        /// </para>
        ///  
        /// <para>
        ///  <code>PRESERVE</code>: Preserve character and block device metadata. This option
        /// isn't currently supported for Amazon EFS. 
        /// </para>
        /// </summary>
        public PreserveDevices PreserveDevices
        {
            get { return this._preserveDevices; }
            set { this._preserveDevices = value; }
        }

        // Check to see if PreserveDevices property is set
        internal bool IsSetPreserveDevices()
        {
            return this._preserveDevices != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityDescriptorCopyFlags. 
        /// <para>
        /// A value that determines which components of the SMB security descriptor are copied
        /// from source to destination objects. 
        /// </para>
        ///  
        /// <para>
        /// This value is only used for transfers between SMB and Amazon FSx for Windows File
        /// Server locations, or between two Amazon FSx for Windows File Server locations. For
        /// more information about how DataSync handles metadata, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/special-files.html">How
        /// DataSync Handles Metadata and Special Files</a>. 
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>OWNER_DACL</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>OWNER_DACL</code>: For each copied object, DataSync copies the following metadata:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Object owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NTFS discretionary access control lists (DACLs), which determine whether to grant
        /// access to an object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When choosing this option, DataSync does NOT copy the NTFS system access control lists
        /// (SACLs), which are used by administrators to log attempts to access a secured object.
        /// </para>
        ///  
        /// <para>
        ///  <code>OWNER_DACL_SACL</code>: For each copied object, DataSync copies the following
        /// metadata:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Object owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NTFS discretionary access control lists (DACLs), which determine whether to grant
        /// access to an object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NTFS system access control lists (SACLs), which are used by administrators to log
        /// attempts to access a secured object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Copying SACLs requires granting additional permissions to the Windows user that DataSync
        /// uses to access your SMB location. For information about choosing a user that ensures
        /// sufficient permissions to files, folders, and metadata, see <a href="create-smb-location.html#SMBuser">user</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>NONE</code>: None of the SMB security descriptor components are copied. Destination
        /// objects are owned by the user that was provided for accessing the destination location.
        /// DACLs and SACLs are set based on the destination server’s configuration. 
        /// </para>
        /// </summary>
        public SmbSecurityDescriptorCopyFlags SecurityDescriptorCopyFlags
        {
            get { return this._securityDescriptorCopyFlags; }
            set { this._securityDescriptorCopyFlags = value; }
        }

        // Check to see if SecurityDescriptorCopyFlags property is set
        internal bool IsSetSecurityDescriptorCopyFlags()
        {
            return this._securityDescriptorCopyFlags != null;
        }

        /// <summary>
        /// Gets and sets the property TaskQueueing. 
        /// <para>
        /// A value that determines whether tasks should be queued before executing the tasks.
        /// If set to <code>ENABLED</code>, the tasks will be queued. The default is <code>ENABLED</code>.
        /// </para>
        ///  
        /// <para>
        /// If you use the same agent to run multiple tasks, you can enable the tasks to run in
        /// series. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#queue-task-execution">Queueing
        /// task executions</a>.
        /// </para>
        /// </summary>
        public TaskQueueing TaskQueueing
        {
            get { return this._taskQueueing; }
            set { this._taskQueueing = value; }
        }

        // Check to see if TaskQueueing property is set
        internal bool IsSetTaskQueueing()
        {
            return this._taskQueueing != null;
        }

        /// <summary>
        /// Gets and sets the property TransferMode. 
        /// <para>
        /// A value that determines whether DataSync transfers only the data and metadata that
        /// differ between the source and the destination location, or whether DataSync transfers
        /// all the content from the source, without comparing to the destination location. 
        /// </para>
        ///  
        /// <para>
        ///  <code>CHANGED</code>: DataSync copies only data or metadata that is new or different
        /// content from the source location to the destination location.
        /// </para>
        ///  
        /// <para>
        ///  <code>ALL</code>: DataSync copies all source location content to the destination,
        /// without comparing to existing content on the destination.
        /// </para>
        /// </summary>
        public TransferMode TransferMode
        {
            get { return this._transferMode; }
            set { this._transferMode = value; }
        }

        // Check to see if TransferMode property is set
        internal bool IsSetTransferMode()
        {
            return this._transferMode != null;
        }

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The POSIX user ID (UID) of the file's owner.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/special-files.html#metadata-copied">Metadata
        /// copied by DataSync</a>.
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>INT_VALUE</code>. This preserves the integer value of the ID.
        /// </para>
        ///  
        /// <para>
        ///  <code>INT_VALUE</code>: Preserve the integer value of UID and group ID (GID) (recommended).
        /// </para>
        ///  
        /// <para>
        ///  <code>NONE</code>: Ignore UID and GID. 
        /// </para>
        /// </summary>
        public Uid Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid != null;
        }

        /// <summary>
        /// Gets and sets the property VerifyMode. 
        /// <para>
        /// A value that determines whether a data integrity verification should be performed
        /// at the end of a task execution after all data and metadata have been transferred.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-task.html">Configure
        /// task settings</a>. 
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>POINT_IN_TIME_CONSISTENT</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>ONLY_FILES_TRANSFERRED</code> (recommended): Perform verification only on files
        /// that were transferred. 
        /// </para>
        ///  
        /// <para>
        ///  <code>POINT_IN_TIME_CONSISTENT</code>: Scan the entire source and entire destination
        /// at the end of the transfer to verify that source and destination are fully synchronized.
        /// This option isn't supported when transferring to S3 Glacier Flexible Retrieval or
        /// S3 Glacier Deep Archive storage classes.
        /// </para>
        ///  
        /// <para>
        ///  <code>NONE</code>: No additional verification is done at the end of the transfer,
        /// but all data transmissions are integrity-checked with checksum verification during
        /// the transfer.
        /// </para>
        /// </summary>
        public VerifyMode VerifyMode
        {
            get { return this._verifyMode; }
            set { this._verifyMode = value; }
        }

        // Check to see if VerifyMode property is set
        internal bool IsSetVerifyMode()
        {
            return this._verifyMode != null;
        }

    }
}