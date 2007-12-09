
/* this file is generated by gen-animation-types.cs.  do not modify */

using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using NUnit.Framework;

namespace MonoTests.System.Windows.Media.Animation {


[TestFixture]
public class ColorAnimationTest
{
	[Test]
	public void Properties ()
	{
		Assert.AreEqual ("By", ColorAnimation.ByProperty.Name, "1");
		Assert.AreEqual (typeof (ColorAnimation), ColorAnimation.ByProperty.OwnerType, "2");
		Assert.AreEqual (typeof (Color?), ColorAnimation.ByProperty.PropertyType, "3");

		Assert.AreEqual ("From", ColorAnimation.FromProperty.Name, "4");
		Assert.AreEqual (typeof (ColorAnimation), ColorAnimation.FromProperty.OwnerType, "5");
		Assert.AreEqual (typeof (Color?), ColorAnimation.FromProperty.PropertyType, "6");

		Assert.AreEqual ("To", ColorAnimation.ToProperty.Name, "7");
		Assert.AreEqual (typeof (ColorAnimation), ColorAnimation.ToProperty.OwnerType, "8");
		Assert.AreEqual (typeof (Color?), ColorAnimation.ToProperty.PropertyType, "9");
	}
}


}
