public class TimeMap {
    private Dictionary<string, List<Tuple<int, string>>> keyStore;

    public TimeMap() {
        keyStore = new Dictionary<string, List<Tuple<int, string>>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!keyStore.ContainsKey(key)) keyStore.Add(key, new List<Tuple<int, string>>());
        keyStore[key].Add(new Tuple<int, string>(timestamp, value));
    }
    
    public string Get(string key, int timestamp)
    {
        if (!keyStore.TryGetValue(key, out var timestamps)) return "";
        var left = 0;
        var right = timestamps.Count - 1;
        string result = "";

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (timestamps[mid].Item1 <= timestamp)
            {
                result = timestamps[mid].Item2;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}
