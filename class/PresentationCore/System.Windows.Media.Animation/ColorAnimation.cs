
/* this file is generated by gen-animation-types.cs.  do not modify */

using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Markup;

namespace System.Windows.Media.Animation {


public class ColorAnimation : ColorAnimationBase
{
	public static readonly DependencyProperty ByProperty
				= DependencyProperty.Register ("By", typeof (Color?), typeof (ColorAnimation));
	public static readonly DependencyProperty FromProperty
				= DependencyProperty.Register ("From", typeof (Color?), typeof (ColorAnimation));
	public static readonly DependencyProperty ToProperty
				= DependencyProperty.Register ("To", typeof (Color?), typeof (ColorAnimation));

	public ColorAnimation ()
	{
	}

	public ColorAnimation (Color toValue, Duration duration)
	{
	}

	public ColorAnimation (Color toValue, Duration duration, FillBehavior fillBehavior)
	{
	}

	public ColorAnimation (Color fromValue, Color toValue, Duration duration)
	{
	}

	public ColorAnimation (Color fromValue, Color tovalue, Duration duration, FillBehavior fillBehavior)
	{
	}

	public Color? By {
		get { return (Color?) GetValue (ByProperty); }
		set { SetValue (ByProperty, value); }
	}

	public Color? From {
		get { return (Color?) GetValue (FromProperty); }
		set { SetValue (FromProperty, value); }
	}

	public Color? To {
		get { return (Color?) GetValue (ToProperty); }
		set { SetValue (ToProperty, value); }
	}

	public bool IsAdditive {
		get { return (bool) GetValue (AnimationTimeline.IsAdditiveProperty); }
		set { SetValue (AnimationTimeline.IsAdditiveProperty, value); }
	}

	public bool IsCumulative {
		get { return (bool) GetValue (AnimationTimeline.IsCumulativeProperty); }
		set { SetValue (AnimationTimeline.IsCumulativeProperty, value); }
	}

	public new ColorAnimation Clone ()
	{
		throw new NotImplementedException ();
	}

	protected override Freezable CreateInstanceCore ()
	{
		return new ColorAnimation ();
	}

	protected override Color GetCurrentValueCore (Color defaultOriginValue, Color defaultDestinationValue, AnimationClock animationClock)
	{
		throw new NotImplementedException ();
	}
}


}
