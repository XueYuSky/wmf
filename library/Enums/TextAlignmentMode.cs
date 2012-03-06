﻿using System;

namespace Oxage.Wmf
{
	public enum TextAlignmentMode
	{
		TA_NOUPDATECP = 0x0000,
		TA_LEFT = 0x0000,
		TA_TOP = 0x0000,
		TA_UPDATECP = 0x0001,
		TA_RIGHT = 0x0002,
		TA_CENTER = 0x0006,
		TA_BOTTOM = 0x0008,
		TA_BASELINE = 0x0018,
		TA_RTLREADING = 0x0100,
		VTA_TOP = TA_LEFT,
		VTA_RIGHT = TA_TOP,
		VTA_BOTTOM = TA_RIGHT,
		VTA_CENTER = TA_CENTER,
		VTA_LEFT = TA_BOTTOM,
		VTA_BASELINE = TA_BASELINE
	}
}
