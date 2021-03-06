//------------------------------------------------------------------------------
//  Copyright (c) 2014-2016 the original author or authors. All Rights Reserved. 
// 
//  NOTICE: You are permitted to use, modify, and distribute this file 
//  in accordance with the terms of the license agreement accompanying it. 
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Robotlegs.Bender.Extensions.ViewManagement.Impl
{
	public class BlankParentFinder : IParentFinder
	{
		public bool Contains (object parentContainer, object childContainer)
		{
			return false;
		}

		public object FindParent (object childView, IEnumerable<ContainerBinding> containers)
		{
			return null;
		}

		public object FindParent (object childView, Dictionary<object, ContainerBinding> containers)
		{
			return null;
		}
	}
}

