﻿namespace AdapterPattern.NoCaching
{
    public class Line
    {
        public Point Start;
        public Point End;

        public Line(Point start, Point end)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
