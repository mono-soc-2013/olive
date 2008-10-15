// RegExpObject.cs
//
// Authors:
//   Olivier Dufour <olivier.duff@gmail.com>
//
// Copyright (C) 2008 Olivier Dufour
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
//

using System;
using Microsoft.Scripting;

namespace Microsoft.JScript.Runtime.Types {

	[Serializable]
	public sealed class RegExpObject : JSObject {

		bool _global;
		bool _ignore_case;
		object _last_index;
		bool _multiline;
		string _source;

		internal RegExpObject (bool global, bool ignoreCase, bool multiline, string source)
			: base (null)
		{
			_global = global;
			_ignore_case = ignoreCase;
			_multiline = multiline;
			_source = source;
		}


		public override void SetItem (SymbolId name, object value)
		{
			base.SetItem (name, value);
		}

		public override bool TryGetItem (SymbolId name, out object value)
		{
			return base.TryGetItem (name, out value);
		}

		public override string GetClassName ()
		{
			return base.GetClassName ();
		}

		public override string ToString ()
		{
			return base.ToString ();
		}

		public bool global {
			get { return _global; }
		}

		public bool ignoreCase {
			get { return _ignore_case; }
		}

		public object lastIndex {
			get { return _last_index; }
			set { _last_index = value; }
		}

		public bool multiline {
			get { return _multiline; }
		}

		public string source {
			get { return _source; }
		}
	}
}
