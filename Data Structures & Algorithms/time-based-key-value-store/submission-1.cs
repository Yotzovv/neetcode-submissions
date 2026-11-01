public class TimeMap {
    private Dictionary<string, SortedList<int, string>> m;

    public TimeMap() {
        m = new Dictionary<string, SortedList<int, string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!m.ContainsKey(key)) m.Add(key, new SortedList<int, string>());
        m[key][timestamp] = value;
    }
    
    public string Get(string key, int timestamp)
    {
        if (!m.TryGetValue(key, out var timestamps)) return "";
        var left = 0;
        var right = timestamps.Count - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (timestamps.Keys[mid] == timestamp) return timestamps.Values[mid];
            if (timestamps.Keys[mid] < timestamp) left = mid + 1;
            else right = mid - 1;
        }

        if (right >= 0) return timestamps.Values[right];
        
        return "";
    }
}
