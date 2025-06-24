using System.Text.Json;
namespace DateTimeHelper;

class DateTimeHandler
{

	public static void Main()
	{
		// Tick - 100 ns interval. All date/time types ultimately count ticks.

		// Clock epoch - .NET’s “tick zero” is midnight 1 Jan 0001 CE UTC (not Unix 1970).

		// DateTime is stored in Ticks

		DateTime dateNowUtc = DateTime.UtcNow;
		 
		Console.WriteLine(dateNowUtc);
    

		Console.WriteLine(JsonSerializer.Serialize(dateNowUtc));

		/* 
		2025-06-24T18:57:03.1702744Z
		└─┬─┘ └────┬────┘ └──┬──┘└────┬────┘└┬┘
		│         │         │        │     └── K  → offset:  “Z”≙UTC, or  “+05:30”,  “-04:00”…  
		│         │         │        └────────── fractional seconds (ticks → 7 digits)  
		│         │         └────────────────── seconds  
		│         └───────────────────────────── date/time separator “T”  
		└─────────────────────────────────────── calendar date
*/
             
		Console.WriteLine(dateNowUtc.ToString("o"));

        // DateTimeOffset = DateTime + offset
		DateTimeOffset utcNow = DateTimeOffset.UtcNow;
		Console.WriteLine(utcNow);
		// prints : 6/24/2025 6:32:48 PM +00:00


		Console.WriteLine(utcNow.ToLocalTime());

		// prints : 6/25/2025 12:02:48 AM +05:30

		Console.WriteLine(utcNow.ToLocalTime().ToUniversalTime());


	}

}