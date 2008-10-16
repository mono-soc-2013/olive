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
// Copyright (c) 2008 Novell, Inc. (http://www.novell.com)
//
// Authors:
//	Alan McGovern (amcgovern@novell.com)
//

using System;

namespace System.IO.Packaging
{
	internal static class Check
	{
		public static void ContentTypeIsValid (string contentType)
		{
			if (string.IsNullOrEmpty (contentType))
				return;

			// Must be in form of: type/subtype
			int index = contentType.IndexOf ('/');
			bool result = (index > 0) && contentType.Length > (index + 1) && contentType.IndexOf ('/', index + 1) == -1;

			if(!result)
				throw new ArgumentException ("contentType", "contentType must be in the form of 'type/subtype'");
		}

		public static void IdIsValid (string id)
		{
			if (id == null)
				return;

			// If the ID is a zero string, need to throw a ArgNullEx
			if (id.Length == 0)
				throw new ArgumentNullException ("id", "Cannot be whitespace or empty");

			// FIXME: I need to XSD parse this to make sure it's valid
			// If it's not, throw an XmlException
		}

		private static bool EmptyOrBlank (string s)
		{
			return (s != null && (s == "" || s.Trim ().Length == 0));
		}
		
		public static void Package(object package)
		{
			if (package == null)
				throw new ArgumentNullException ("package");
		}

		public static void PartUri(object partUri)
		{
			if (partUri == null)
				throw new ArgumentNullException ("partUri");
		}

		public static void RelationshipTypeIsValid (string relationshipType)
		{
			if (relationshipType == null)
				throw new ArgumentNullException ("relationshipType");
			if (EmptyOrBlank (relationshipType))
				throw new ArgumentException ("relationshipType", "Cannot be whitespace or empty");
		}

		public static void SourceUri (object sourceUri)
		{
			if (sourceUri == null)
				throw new ArgumentNullException ("sourceUri");
		}

		public static void TargetUri (object targetUri)
		{
			if (targetUri == null)
				throw new ArgumentNullException ("targetUri");
		}

		public static void UriIsRelative (Uri partUri)
		{
			if (partUri.IsAbsoluteUri)
				throw new ArgumentException ("partUri", "Absolute URIs are not supported");
		}
	}
}
