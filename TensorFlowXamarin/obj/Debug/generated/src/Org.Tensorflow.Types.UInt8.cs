using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Tensorflow.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.tensorflow.types']/class[@name='UInt8']"
	[global::Android.Runtime.Register ("org/tensorflow/types/UInt8", DoNotGenerateAcw=true)]
	public partial class UInt8 : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/tensorflow/types/UInt8", typeof (UInt8));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected UInt8 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
