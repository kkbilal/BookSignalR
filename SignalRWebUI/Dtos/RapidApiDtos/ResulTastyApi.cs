namespace SignalRWebUI.Dtos.RapidApiDtos
{
    public class RootTastyApi
    {
        public List<ResulTastyApi> results { get; set; }
    }
	public class ResulTastyApi
	{
        public string Name { get; set; }
        public string original_video_url { get; set; }
        
        public string thumbnail_url { get; set; }

        public int total_time_minutes  { get; set; }
    }
}
