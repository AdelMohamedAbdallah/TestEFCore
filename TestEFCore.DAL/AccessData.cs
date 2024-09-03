namespace TestEFCore
{
    public static class AccessData
    {
        public static IEnumerable<TSource> GetAllData<TSource>(this IEnumerable<TSource> source)
        {
            foreach (var item in source.ToList())
                yield return item;
        }

        public static void Print<TSource>(this IEnumerable<TSource> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }

    }
}
