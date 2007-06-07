//
// Value.cs: represents the unmanaged Value structure from runtime.cpp
//
// Author:
//   Miguel de Icaza (miguel@novell.com)
//
// Copyright 2007 Novell, Inc.
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
using System.Windows;
using System.Runtime.InteropServices;

namespace Mono {

	[StructLayout(LayoutKind.Explicit)]
	public struct Value {

		// Keep this in sync with runtime.h
		public enum Kind {
	                INVALID = 0,
	                BOOL = 1,
	                DOUBLE = 2,
	                UINT64 = 3,
	                INT32 = 4,
	                STRING = 5,
	                COLOR = 7,
	                POINT = 8,
	                RECT = 9,
	                REPEATBEHAVIOR = 10,
	                DURATION = 11,
	                INT64 = 12,
	
	                DEPENDENCY_OBJECT = 1000,
	
	                // These are dependency objects
	                UIELEMENT,
	                PANEL,
	                CANVAS,
	                TIMELINE,
	                TRANSFORM,
	                ROTATETRANSFORM,
	                SCALETRANSFORM,
	                TRANSLATETRANSFORM,
	                MATRIXTRANSFORM,
	                STORYBOARD,
	                DOUBLEANIMATION,
	                COLORANIMATION,
	                POINTANIMATION,
	                SHAPE,
	                ELLIPSE,
	                LINE,
	                PATH,
	                POLYGON,
	                POLYLINE,
	                RECTANGLE,
	                GEOMETRY,
	                GEOMETRYGROUP,
	                ELLIPSEGEOMETRY,
	                LINEGEOMETRY,
	                PATHGEOMETRY,
	                RECTANGLEGEOMETRY,
	                FRAMEWORKELEMENT,
	                NAMESCOPE,
	                CLOCK,
	                ANIMATIONCLOCK,
	                CLOCKGROUP,
	                BRUSH,
	                SOLIDCOLORBRUSH,
	                PATHFIGURE,
	                ARCSEGMENT,
	                BEZIERSEGMENT,
	                LINESEGMENT,
	                POLYBEZIERSEGMENT,
	                POLYLINESEGMENT,
	                POLYQUADRATICBEZIERSEGMENT,
	                QUADRATICBEZIERSEGMENT,
	                TRIGGERACTION,
	                BEGINSTORYBOARD,
	                EVENTTRIGGER,
		}

		[FieldOffset (0)]
		public Kind k;

		[FieldOffset (4)]
		public long vlong; // The biggest size
	}
}
