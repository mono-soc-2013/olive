
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
public class VectorAnimationTest
{
	[Test]
	public void Properties ()
	{
		Assert.AreEqual ("By", VectorAnimation.ByProperty.Name, "1");
		Assert.AreEqual (typeof (VectorAnimation), VectorAnimation.ByProperty.OwnerType, "2");
		Assert.AreEqual (typeof (Vector?), VectorAnimation.ByProperty.PropertyType, "3");

		Assert.AreEqual ("From", VectorAnimation.FromProperty.Name, "4");
		Assert.AreEqual (typeof (VectorAnimation), VectorAnimation.FromProperty.OwnerType, "5");
		Assert.AreEqual (typeof (Vector?), VectorAnimation.FromProperty.PropertyType, "6");

		Assert.AreEqual ("To", VectorAnimation.ToProperty.Name, "7");
		Assert.AreEqual (typeof (VectorAnimation), VectorAnimation.ToProperty.OwnerType, "8");
		Assert.AreEqual (typeof (Vector?), VectorAnimation.ToProperty.PropertyType, "9");
	}
}


}
