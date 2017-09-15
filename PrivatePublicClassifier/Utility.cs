namespace PrivatePublicClassifier
{
    public static class Utility
    {
        public static bool LooksLikeMethodLine(string line)
        {
            var commentIndex = line.IndexOf("//");
            if (commentIndex != -1)
            {
                line = line.Substring(0, commentIndex);
            }

            return line.Contains("(")
                   && line.Contains(")")
                   && !line.Trim().EndsWith(";");
        }
    }
}
