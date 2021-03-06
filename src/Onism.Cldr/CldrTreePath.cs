using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Onism.Cldr
{
    /// <summary>
    /// Represents a queue of edges to choose while traversing a <see cref="CldrTree"/>.
    /// </summary>
    internal class CldrTreePath : Queue<CldrTreePathSegment>
    {
        private static readonly Regex PathRegex;

        static CldrTreePath()
        {
            const string index = @"\[(?<index>[0-9]+)\]";         // [0]
            const string key = @"(?<key>[a-zA-Z0-9-_%/,$\+\*]+)"; // year
            const string special = @"\['(?<key>[^']+)'\]";        // ['x.x']

            var firstSegment = $@"(({index})|({key})|({special}))";
            var nextSegment = $@"(({index})|(\.{key})|({special}))*";

            var pattern = $"^{firstSegment}{nextSegment}$";
            PathRegex = new Regex(pattern);
        }

        public static CldrTreePath Parse(string path)
        {
            var match = PathRegex.Match(path);
            var keys = match.Groups["key"].Captures.Cast<Capture>().Select(x => new {x.Index, x.Value, IsKey = true});
            var indexes = match.Groups["index"].Captures.Cast<Capture>().Select(x => new {x.Index, x.Value, IsKey = false});

            var merged = keys.Concat(indexes).OrderBy(x => x.Index);

            var result = new CldrTreePath();

            //if (!match.Success)
            //  throw new FormatException($"Path segment expected to match '{pattern}' but was '{potentialSegment}'.");

            foreach (var capture in merged)
            {
                if (capture.IsKey)
                    result.Enqueue(new CldrTreePathSegment(capture.Value));
                else
                    result.Enqueue(new CldrTreePathSegment(int.Parse(capture.Value)));
            }

            return result;
        }
    }
}