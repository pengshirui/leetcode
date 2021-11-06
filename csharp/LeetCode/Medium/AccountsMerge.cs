namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.DataStructures;

    public partial class Solution
    {
        Dictionary<string, int> EmailToId;
        Dictionary<string, string> EmailToName;

        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            EmailToId = new Dictionary<string, int>();
            EmailToName = new Dictionary<string, string>();

            foreach (var account in accounts)
            {
                if (account.Count < 2)
                {
                    continue;
                }

                var name = account[0];
                for (var i = 1; i < account.Count; i++)
                {
                    if (!EmailToId.ContainsKey(account[i]))
                    {
                        var id = EmailToId.Count;
                        EmailToId[account[i]] = id;
                        EmailToName[account[i]] = name;
                    }
                }
            }

            var totalAccounts = EmailToId.Count;
            DSU = new DSU(totalAccounts);

            foreach (var account in accounts)
            {
                // var name = account[0];
                for (var i = 1; i < account.Count - 1; i++)
                {
                    var id1 = EmailToId[account[i]];
                    var id2 = EmailToId[account[i + 1]];

                    if (id1 != id2)
                    {
                        DSU.Union(id1, id2);
                    }
                }
            }

            var result = new Dictionary<int, List<string>>();
            foreach (var email in EmailToName.Keys)
            {
                int index = DSU.Find(EmailToId[email]);
                if (result.TryGetValue(index, out var list))
                {
                    list.Add(email);
                }
                else
                {
                    result[index] = new List<string> { email };
                }
            }
            foreach (var emails in result.Values)
            {
                emails.Sort((x, y) =>
                {
                    var i = 0;
                    while (i < x.Length && i < y.Length)
                    {
                        if (x[i] != y[i])
                        {
                            return x[i].CompareTo(y[i]);
                        }
                        i++;
                    }
                    return x.Length.CompareTo(y.Length);
                });
                emails.Insert(0, EmailToName[emails[0]]);
            }
            return result.Values.ToList<IList<string>>();
        }
    }

}
