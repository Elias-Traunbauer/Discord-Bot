﻿
namespace Netdb
{
    public class MovieData
    {
        private string _name;
        private string _type;
        private string _description;
        private string _link;
        private int _id;
        private int _age;
        private int _releasedate;
        private string _length;
        private string _genres;
        private int _review;
        private int _averagereview;
        private double _totalreview;
        private byte[] _image;
        private string _netflixid;
        private bool _hasreviewed;

        public bool Hasreviewed
        {
            get { return _hasreviewed; }
            set { _hasreviewed = value; }
        }


        public string Netflixid
        {
            get { return _netflixid; }
            set { _netflixid = value; }
        }


        public byte[] Image
        {
            get { return _image; }
            set { _image = value; }
        }


        public double Totalreview
        {
            get { return _totalreview; }
            set { _totalreview = value; }
        }


        public int AverageReview
        {
            get { return _averagereview; }
            set { _averagereview = value; }
        }


        public int Review
        {
            get { return _review; }
            set { _review = value; }
        }


        public string Genres
        {
            get { return _genres; }
            set { _genres = value; }
        }


        public string Length
        {
            get { return _length; }
            set { _length = value; }
        }


        public int Releasedate
        {
            get { return _releasedate; }
            set { _releasedate = value; }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }


        public string  Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
