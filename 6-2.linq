<Query Kind="Program">
  <Namespace>System.Buffers</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

void Main()
{
	var content = File.ReadAllText(@"C:\Projects\adventofcode\aoc-2020\input\6-1.txt");
	var groups = content.Split("\n\n");
	var total = 0;
	foreach (var group in groups)
	{
		//group.Dump("Group");
		var peopleRaw = group.Split("\n");
		var people = peopleRaw.Where(x => !string.IsNullOrEmpty(x)).ToList();
		people.Dump("People");
		var hashSet = new HashSet<char>(people.First().ToArray());
		foreach (var p in people.Skip(1))
		{
			hashSet.IntersectWith(p.ToArray());
		}
		var intersection = hashSet.ToList();
		intersection.Dump("Intersection");
		var count = intersection.Count().Dump();
		total += count;
	}
	total.Dump();
}


