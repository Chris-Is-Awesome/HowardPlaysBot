﻿using System;
using System.Threading.Tasks;

namespace HowardBot
{
	public static class Utility
	{
		public static string Timestamp
		{
			get
			{
				return $"[{DateTime.Now:hh:mm:ss.fff}]";
			}
		}

		public static int GetRandomNumberInRange(int min, int max, bool maxInclusive = true)
		{
			Random rand = new Random();
			return rand.Next(min, maxInclusive ? max + 1 : max);
		}

		public static async Task WaitForSeconds(float seconds)
		{
			await Task.Delay(TimeSpan.FromSeconds(seconds));
		}

		public static async Task WaitForMilliseconds(float milliseconds)
		{
			await Task.Delay(TimeSpan.FromMilliseconds(milliseconds));
		}
	}
}