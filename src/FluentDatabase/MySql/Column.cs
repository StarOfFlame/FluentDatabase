﻿#region License
// Copyright 2009 Josh Close
// This file is a part of FluentDatabase and is licensed under the MS-PL
// See LICENSE.txt for details or visit http://www.opensource.org/licenses/ms-pl.html
#endregion
using System;
using System.IO;

namespace FluentDatabase.MySql
{
	public class Column : ColumnBase
	{
		protected override void WriteColumn( StreamWriter writer )
		{
		}

		protected override IConstraint CreateConstraint()
		{
			return new Constraint();
		}
	}
}
