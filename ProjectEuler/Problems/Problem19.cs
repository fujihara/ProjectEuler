using System;
using System.Globalization;

namespace ProjectEuler
{
	public class Problem19 : Problem
	{
		public Problem19 ()
		{
			this.problemId = 19;
			this.problemName = "Counting Sundays"; 
			this.problemDescription = "You are given the following information, but you may prefer to do some research for yourself.\n\n1 Jan 1900 was a Monday.\nThirty days has September,\nApril, June and November.\nAll the rest have thirty-one,\nSaving February alone,\nWhich has twenty-eight, rain or shine.\nAnd on leap years, twenty-nine.\nA leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.\nHow many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?";
		}

		public override void Solve ()
		{
			var calendar = new GregorianCalendar ();
			var date = new DateTime (1901, 1, 1, calendar);
			var endDate = new DateTime (2000, 12, 31, calendar);

			var sundays = 0;
			while (date < endDate) {
				if (date.DayOfWeek == DayOfWeek.Sunday) {
					sundays++;
				}
				date = date.AddMonths (1);
			}

			Console.WriteLine ("Sundays: " + sundays);
		}
	}
}

