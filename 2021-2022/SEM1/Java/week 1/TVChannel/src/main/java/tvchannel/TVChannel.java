package tvchannel;

import java.util.ArrayList;

public class TVChannel {
    private String list;
    private ArrayList<TVShow> tvShows;

    public String getList() {
        return list;
    }

    public void setList(String list) {
        this.list = list;
    }

    public ArrayList<TVShow> getTvShows() {
        return tvShows;
    }

    public void setTvShows(ArrayList<TVShow> tvShows) {
        this.tvShows = tvShows;
    }

    public TVChannel(String list, ArrayList<TVShow> tvShows) {
        this.list = list;
        this.tvShows = tvShows;
    }
}
