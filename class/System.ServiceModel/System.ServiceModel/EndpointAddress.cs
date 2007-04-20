//
// System.ServiceModel.EndpointAddress.cs
//
// Author: Duncan Mak (duncan@novell.com)
//	   Atsushi Enomoto (atsushi@ximian.com)
//
// Copyright (C) 2005-2006 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.ServiceModel.Channels;

namespace System.ServiceModel
{
	public class EndpointAddress
	{
		static readonly Uri w3c_anonymous = new Uri (Constants.WsaAnonymousUri);
		static readonly Uri anonymous_role = new Uri ("http://schemas.microsoft.com/2005/12/ServiceModel/Addressing/Anonymous");
		static readonly Uri none_role = new Uri ("http://schemas.microsoft.com/2005/12/ServiceModel/Addressing/None");

		public static Uri AnonymousUri {
			get { return anonymous_role; }
		}

		public static Uri NoneUri {
			get { return none_role; }
		}

		Uri address;
		AddressHeaderCollection headers;
		EndpointIdentity identity;
		XmlDictionaryReader metadata_reader;
		XmlDictionaryReader extension_reader;

		static XmlSchema schema;

		public EndpointAddress (string uri)
			: this (new Uri (uri)) {}

		EndpointAddress (Uri uri)
		{
			if (uri == null)
				throw new ArgumentNullException ();
			this.address = uri;
			headers = new AddressHeaderCollection (new AddressHeader [0]);
		}

		public EndpointAddress (Uri uri, params AddressHeader [] headers)
			: this (uri, null, new AddressHeaderCollection (headers), null, null) {}

		public EndpointAddress (Uri uri, EndpointIdentity identity, params AddressHeader [] headers)
			: this (uri, identity, new AddressHeaderCollection (headers), null, null) {}

		public EndpointAddress (Uri uri, EndpointIdentity identity, AddressHeaderCollection headers)
			: this (uri, identity, headers, null, null) {}

		public EndpointAddress (
			Uri uri, EndpointIdentity identity,
			AddressHeaderCollection headers,
			XmlDictionaryReader metadataReader,
			XmlDictionaryReader extensionReader)
		{	
			if (uri == null)
				throw new ArgumentNullException ();
			this.address = uri;
			this.identity = identity;
			this.headers = headers;
			metadata_reader = metadataReader;
			extension_reader = extensionReader;
		}

		public bool IsAnonymous {
			get { return address.Equals (anonymous_role); }
		}

		public bool IsNone {
			get { return address.Equals (none_role); }
		}

		public AddressHeaderCollection Headers {
			get { return headers; }
		}

		public EndpointIdentity Identity {
			get { return identity; }
		}

		public Uri Uri {
			get { return address; }
		}

		internal static XmlSchema Schema {
			get {
				if (schema == null) {
					Assembly a = Assembly.GetCallingAssembly ();
					Stream s = a.GetManifestResourceStream ("WS-Addressing.schema");
					schema = XmlSchema.Read (s, null);
				}

				return schema;
			}
		}

		[MonoTODO]
		public void ApplyTo (Message message)
		{
			throw new NotImplementedException ();
		}

		public override bool Equals (object obj)
		{
			EndpointAddress other = obj as EndpointAddress;
			if (other == null || 
			    other.Uri == null || !other.Uri.Equals (this.Uri) ||
			    other.Headers.Count != this.Headers.Count)
				return false;

			foreach (AddressHeader h in this.Headers) {
				bool match = false;
				foreach (AddressHeader o in other.Headers)
					if (h.Equals (o)) {
						match = true;
						break;
					}
				if (!match)
					return false;
			}

			return true;
		}

		public override int GetHashCode ()
		{
			return address.GetHashCode ();
		}

		public XmlDictionaryReader GetReaderAtExtensions ()
		{
			return extension_reader;
		}

		public XmlDictionaryReader GetReaderAtMetadata ()
		{
			return metadata_reader;
		}

		public static bool operator == (EndpointAddress address1, EndpointAddress address2)
		{
			if ((object) address1 == null)
				return (object) address2 == null;
			if ((object) address2 == null)
				return false;
			return address1.Equals (address2);
		}

		public static bool operator != (EndpointAddress address1, EndpointAddress address2)
		{
			return ! (address1 == address2);
		}

		[MonoTODO]
		public static EndpointAddress ReadFrom (
			XmlDictionaryReader reader)
		{
			if (reader == null)
				throw new ArgumentNullException ("reader");

			return ReadFromInternal (null, reader);
		}

		[MonoTODO]
		public static EndpointAddress ReadFrom (
			AddressingVersion addressingVersion,
			XmlDictionaryReader reader)
		{
			return ReadFrom (addressingVersion, (XmlReader) reader);
		}

		[MonoTODO]
		public static EndpointAddress ReadFrom (
			AddressingVersion addressingVersion,
			XmlReader reader)
		{
			if (addressingVersion == null)
				throw new ArgumentNullException ("addressingVersion");
			if (reader == null)
				throw new ArgumentNullException ("reader");

			return ReadFromInternal (addressingVersion, reader);
		}

		[MonoTODO]
		public static EndpointAddress ReadFrom (
			XmlDictionaryReader reader,
			XmlDictionaryString localName,
			XmlDictionaryString ns)
		{
			return ReadFrom (AddressingVersion.WSAddressing10,
					 reader, localName, ns);
		}


		[MonoTODO]
		public static EndpointAddress ReadFrom (
			AddressingVersion addressingVersion,
			XmlDictionaryReader reader,
			XmlDictionaryString localName,
			XmlDictionaryString ns)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public static EndpointAddress ReadFrom (
			AddressingVersion addressingVersion,
			XmlReader reader, string localname, string ns)
		{
			throw new NotImplementedException ();
		}

		private static EndpointAddress ReadFromInternal (
			AddressingVersion addressingVersion,
			XmlReader reader)
		{
			reader.MoveToContent ();
			if (reader.NodeType == XmlNodeType.Element &&
			    !reader.IsEmptyElement) {
				reader.Read ();
				reader.MoveToContent ();

				if (addressingVersion == null) {
					if (reader.NamespaceURI == AddressingVersion.WSAddressing10.Namespace)
						addressingVersion = AddressingVersion.WSAddressing10;
					else
					if (reader.NamespaceURI == AddressingVersion.WSAddressingAugust2004.Namespace)
						addressingVersion = AddressingVersion.WSAddressingAugust2004;
					else
						throw new ArgumentException ("Cannot detect appropriate WS-Addressing version.");
				}
				
				if (reader.LocalName == "Address" && 
					reader.NamespaceURI == addressingVersion.Namespace &&
					reader.NodeType == XmlNodeType.Element &&
					!reader.IsEmptyElement) {

					EndpointAddress a = new EndpointAddress (
						reader.ReadElementContentAsString ());
					if (addressingVersion == AddressingVersion.WSAddressing10 && 
						a.Uri == w3c_anonymous)
						a = new EndpointAddress (anonymous_role);

					reader.MoveToContent ();
					reader.ReadEndElement ();
					return a;
				}

				throw new XmlException (String.Format (
						"Expecting 'Address' from namespace '{0}', but found '{1}' from namespace '{2}'",
						addressingVersion.Namespace, reader.LocalName, reader.NamespaceURI));
			}
			throw new ArgumentException ("Cannot detect appropriate WS-Addressing Address element.");
		}

		public override string ToString ()
		{
			return address.ToString (); 
		}

		[MonoTODO]
		public void WriteContentsTo (
			AddressingVersion addressingVersion,
			XmlDictionaryWriter writer)
		{
			if (addressingVersion == AddressingVersion.WSAddressing10) {
				((IXmlSerializable) EndpointAddress10.FromEndpointAddress (this)).WriteXml (writer);
			} else {
				writer.WriteString (Uri.AbsoluteUri);
			}
		}

		public void WriteContentsTo (
			AddressingVersion addressingVersion,
			XmlWriter writer)
		{
			WriteContentsTo (addressingVersion,
				XmlDictionaryWriter.CreateDictionaryWriter (writer));
		}

		public void WriteTo (
			AddressingVersion addressingVersion,
			XmlDictionaryWriter writer)
		{
			WriteTo (addressingVersion, writer, "EndpointReference", addressingVersion.Namespace);
		}

		public void WriteTo (
			AddressingVersion addressingVersion, XmlWriter writer)
		{
			WriteTo (addressingVersion,
				XmlDictionaryWriter.CreateDictionaryWriter (writer));
		}

		public void WriteTo (
			AddressingVersion addressingVersion,
			XmlDictionaryWriter writer,
			XmlDictionaryString localname,
			XmlDictionaryString ns)
		{
			writer.WriteStartElement (localname, ns);
			WriteContentsTo (addressingVersion, writer);
			writer.WriteEndElement ();
		}

		public void WriteTo (
			AddressingVersion addressingVersion,
			XmlWriter writer, string localname, string ns)
		{
			writer.WriteStartElement (localname, ns);
			WriteContentsTo (addressingVersion, writer);
			writer.WriteEndElement ();
		}
	}
}
