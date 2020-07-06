using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DemoConsole.Design
{
    public class Twitter
    {
        static int counter;
        Dictionary<int, List<int>> followdict;
        Dictionary<int, List<Tweet>> tweet;
        /** Initialize your data structure here. */
        public Twitter()
        {
            counter = 1;
            followdict = new Dictionary<int, List<int>>();
            tweet = new Dictionary<int, List<Tweet>>();
        }

        /** Compose a new tweet. */
        public void PostTweet(int userId, int tweetId)
        {
            var t = new Tweet(counter++, tweetId);
            if (tweet.ContainsKey(userId))
            {
                if (tweet[userId] == null)
                    tweet[userId] = new List<Tweet>() { t };
                else
                    tweet[userId].Add(t);
            }
            else
                tweet.Add(userId, new List<Tweet>() { t });
        }

        /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
        public IList<int> GetNewsFeed(int userId)
        {
            var alltweets = new List<Tweet>();
            if (tweet.ContainsKey(userId) && tweet[userId] != null)
                alltweets.AddRange(tweet[userId]);

            if (followdict.ContainsKey(userId))
            {
                foreach (var people in followdict[userId])
                {
                    if (tweet.ContainsKey(people) && tweet[people] != null)
                        alltweets.AddRange(tweet[people]);
                }
            }
            alltweets.Sort(new compareTweetClass());

            var latestData =alltweets.Take(10);
            return convertToIntList(latestData);

        }
        private List<int> convertToIntList(IEnumerable<Tweet> tweets)
        {
            var res = new List<int>();
            if (tweets == null )
                return res;

            foreach (var tweet in tweets)
                res.Add(tweet.tweet);
            return res;
        }

        /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
        public void Follow(int followerId, int followeeId)
        {
            if (followerId == followeeId)
                return;
            if (followdict.ContainsKey(followerId))
            {
                if (followdict[followerId] == null)
                    followdict[followerId] = new List<int>() { followeeId };
                else
                {
                    if(!followdict[followerId].Contains(followeeId))
                    followdict[followerId].Add(followeeId);
                }
            }
            else
                followdict.Add(followerId, new List<int>() { followeeId });
        }

        /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
        public void Unfollow(int followerId, int followeeId)
        {
            if (followdict.ContainsKey(followerId))
            {
                if (followdict[followerId] != null)
                    followdict[followerId].Remove(followeeId);
            }
        }
    }
    public class Tweet
    {
        public int id;
        public int tweet;

        public Tweet(int time, int t)
        {
            id = time;
            tweet = t;
        }
    }

    public class compareTweetClass : IComparer<Tweet>
    {

        public int Compare(Tweet x, Tweet y)
        {
            //ascending order 
            return y.id - x.id;
        }
    }
}
