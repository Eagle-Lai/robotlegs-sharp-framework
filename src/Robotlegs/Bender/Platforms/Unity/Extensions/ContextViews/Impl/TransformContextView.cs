//------------------------------------------------------------------------------
//  Copyright (c) 2014-2016 the original author or authors. All Rights Reserved. 
// 
//  NOTICE: You are permitted to use, modify, and distribute this file 
//  in accordance with the terms of the license agreement accompanying it. 
//------------------------------------------------------------------------------

using Robotlegs.Bender.Extensions.ContextViews.API;
using UnityEngine;

namespace Robotlegs.Bender.Platforms.Unity.Extensions.ContextViews.Impl
{
	public class TransformContextView : IContextView
	{
		/*============================================================================*/
		/* Public Properties                                                          */
		/*============================================================================*/

		public object view
		{
			get 
			{
				return _transform;
			}
		}
		
		public Transform transform
		{
			get
			{
				return _transform;
			}
		}

		/*============================================================================*/
		/* Private Properties                                                         */
		/*============================================================================*/
		
		private Transform _transform;

		/*============================================================================*/
		/* Public Functions                                                           */
		/*============================================================================*/

		public TransformContextView (Transform view)
		{
			_transform = view;
		}
	}
}

