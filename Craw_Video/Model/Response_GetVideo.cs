using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craw_Video.Model
{
    public class Response_GetVideo
    {
        public Data data { get; set; }
        public string status { get; set; }
    }

    public class Data
    {
        public User user { get; set; }
    }

    public class User
    {
        public object ai_agent_type { get; set; }
        public string biography { get; set; }
        public Bio_Links[] bio_links { get; set; }
        public object fb_profile_biolink { get; set; }
        public Biography_With_Entities biography_with_entities { get; set; }
        public bool blocked_by_viewer { get; set; }
        public object restricted_by_viewer { get; set; }
        public bool country_block { get; set; }
        public string eimu_id { get; set; }
        public string external_url { get; set; }
        public string external_url_linkshimmed { get; set; }
        public Edge_Followed_By edge_followed_by { get; set; }
        public string fbid { get; set; }
        public bool followed_by_viewer { get; set; }
        public Edge_Follow edge_follow { get; set; }
        public bool follows_viewer { get; set; }
        public string full_name { get; set; }
        public object group_metadata { get; set; }
        public bool has_ar_effects { get; set; }
        public bool has_clips { get; set; }
        public bool has_guides { get; set; }
        public bool has_channel { get; set; }
        public bool has_blocked_viewer { get; set; }
        public int highlight_reel_count { get; set; }
        public bool has_requested_viewer { get; set; }
        public bool hide_like_and_view_counts { get; set; }
        public string id { get; set; }
        public bool is_business_account { get; set; }
        public bool is_professional_account { get; set; }
        public bool is_supervision_enabled { get; set; }
        public bool is_guardian_of_viewer { get; set; }
        public bool is_supervised_by_viewer { get; set; }
        public bool is_supervised_user { get; set; }
        public bool is_embeds_disabled { get; set; }
        public bool is_joined_recently { get; set; }
        public object guardian_id { get; set; }
        public string business_address_json { get; set; }
        public string business_contact_method { get; set; }
        public object business_email { get; set; }
        public object business_phone_number { get; set; }
        public object business_category_name { get; set; }
        public object overall_category_name { get; set; }
        public object category_enum { get; set; }
        public string category_name { get; set; }
        public bool is_private { get; set; }
        public bool is_verified { get; set; }
        public bool is_verified_by_mv4b { get; set; }
        public bool is_regulated_c18 { get; set; }
        public Edge_Mutual_Followed_By edge_mutual_followed_by { get; set; }
        public int pinned_channels_list_count { get; set; }
        public string profile_pic_url { get; set; }
        public string profile_pic_url_hd { get; set; }
        public bool requested_by_viewer { get; set; }
        public bool should_show_category { get; set; }
        public bool should_show_public_contacts { get; set; }
        public bool show_account_transparency_details { get; set; }
        public bool remove_message_entrypoint { get; set; }
        public object transparency_label { get; set; }
        public object transparency_product { get; set; }
        public string username { get; set; }
        public object connected_fb_page { get; set; }
        public object[] pronouns { get; set; }
        public Edge_Felix_Video_Timeline edge_felix_video_timeline { get; set; }
        public Edge_Owner_To_Timeline_Media edge_owner_to_timeline_media { get; set; }
        public Edge_Saved_Media edge_saved_media { get; set; }
        public Edge_Media_Collections edge_media_collections { get; set; }
        public Edge_Related_Profiles edge_related_profiles { get; set; }
    }

    public class Biography_With_Entities
    {
        public string raw_text { get; set; }
        public Entity[] entities { get; set; }
    }

    public class Entity
    {
        public User1 user { get; set; }
        public Hashtag hashtag { get; set; }
    }

    public class User1
    {
        public string username { get; set; }
    }

    public class Hashtag
    {
        public string name { get; set; }
    }

    public class Edge_Followed_By
    {
        public int count { get; set; }
    }

    public class Edge_Follow
    {
        public int count { get; set; }
    }

    public class Edge_Mutual_Followed_By
    {
        public int count { get; set; }
        public object[] edges { get; set; }
    }

    public class Edge_Felix_Video_Timeline
    {
        public int count { get; set; }
        public Page_Info page_info { get; set; }
        public Edge[] edges { get; set; }
    }

    public class Page_Info
    {
        public bool has_next_page { get; set; }
        public string end_cursor { get; set; }
    }

    public class Edge
    {
        public Node node { get; set; }
    }

    public class Node
    {
        public string __typename { get; set; }
        public string id { get; set; }
        public string shortcode { get; set; }
        public Dimensions dimensions { get; set; }
        public string display_url { get; set; }
        public Edge_Media_To_Tagged_User edge_media_to_tagged_user { get; set; }
        public object fact_check_overall_rating { get; set; }
        public object fact_check_information { get; set; }
        public object gating_info { get; set; }
        public Sharing_Friction_Info sharing_friction_info { get; set; }
        public object media_overlay_info { get; set; }
        public string media_preview { get; set; }
        public Owner owner { get; set; }
        public bool is_video { get; set; }
        public bool has_upcoming_event { get; set; }
        public object accessibility_caption { get; set; }
        public Dash_Info dash_info { get; set; }
        public bool has_audio { get; set; }
        public string tracking_token { get; set; }
        public string video_url { get; set; }
        public int video_view_count { get; set; }
        public Edge_Media_To_Caption edge_media_to_caption { get; set; }
        public Edge_Media_To_Comment edge_media_to_comment { get; set; }
        public bool comments_disabled { get; set; }
        public int taken_at_timestamp { get; set; }
        public Edge_Liked_By edge_liked_by { get; set; }
        public Edge_Media_Preview_Like edge_media_preview_like { get; set; }
        public object location { get; set; }
        public object nft_asset_info { get; set; }
        public string thumbnail_src { get; set; }
        public Thumbnail_Resources[] thumbnail_resources { get; set; }
        public Felix_Profile_Grid_Crop felix_profile_grid_crop { get; set; }
        public object[] coauthor_producers { get; set; }
        public object[] pinned_for_users { get; set; }
        public bool viewer_can_reshare { get; set; }
        public object encoding_status { get; set; }
        public bool is_published { get; set; }
        public string product_type { get; set; }
        public string title { get; set; }
        public float video_duration { get; set; }
    }

    public class Dimensions
    {
        public int height { get; set; }
        public int width { get; set; }
    }

    public class Edge_Media_To_Tagged_User
    {
        public object[] edges { get; set; }
    }

    public class Sharing_Friction_Info
    {
        public bool should_have_sharing_friction { get; set; }
        public object bloks_app_url { get; set; }
    }

    public class Owner
    {
        public string id { get; set; }
        public string username { get; set; }
    }

    public class Dash_Info
    {
        public bool is_dash_eligible { get; set; }
        public object video_dash_manifest { get; set; }
        public int number_of_qualities { get; set; }
    }

    public class Edge_Media_To_Caption
    {
        public Edge1[] edges { get; set; }
    }

    public class Edge1
    {
        public Node1 node { get; set; }
    }

    public class Node1
    {
        public string text { get; set; }
    }

    public class Edge_Media_To_Comment
    {
        public int count { get; set; }
    }

    public class Edge_Liked_By
    {
        public int count { get; set; }
    }

    public class Edge_Media_Preview_Like
    {
        public int count { get; set; }
    }

    public class Felix_Profile_Grid_Crop
    {
        public float crop_left { get; set; }
        public float crop_right { get; set; }
        public float crop_top { get; set; }
        public float crop_bottom { get; set; }
    }

    public class Thumbnail_Resources
    {
        public string src { get; set; }
        public int config_width { get; set; }
        public int config_height { get; set; }
    }

    public class Edge_Owner_To_Timeline_Media
    {
        public int count { get; set; }
        public Page_Info1 page_info { get; set; }
        public Edge2[] edges { get; set; }
    }

    public class Page_Info1
    {
        public bool has_next_page { get; set; }
        public string end_cursor { get; set; }
    }

    public class Edge2
    {
        public Node2 node { get; set; }
    }

    public class Node2
    {
        public string __typename { get; set; }
        public string id { get; set; }
        public string shortcode { get; set; }
        public Dimensions1 dimensions { get; set; }
        public string display_url { get; set; }
        public Edge_Media_To_Tagged_User1 edge_media_to_tagged_user { get; set; }
        public object fact_check_overall_rating { get; set; }
        public object fact_check_information { get; set; }
        public object gating_info { get; set; }
        public Sharing_Friction_Info1 sharing_friction_info { get; set; }
        public object media_overlay_info { get; set; }
        public string media_preview { get; set; }
        public Owner1 owner { get; set; }
        public bool is_video { get; set; }
        public bool has_upcoming_event { get; set; }
        public string accessibility_caption { get; set; }
        public Edge_Media_To_Caption1 edge_media_to_caption { get; set; }
        public Edge_Media_To_Comment1 edge_media_to_comment { get; set; }
        public bool comments_disabled { get; set; }
        public int taken_at_timestamp { get; set; }
        public Edge_Liked_By1 edge_liked_by { get; set; }
        public Edge_Media_Preview_Like1 edge_media_preview_like { get; set; }
        public object location { get; set; }
        public object nft_asset_info { get; set; }
        public string thumbnail_src { get; set; }
        public Thumbnail_Resources1[] thumbnail_resources { get; set; }
        public object[] coauthor_producers { get; set; }
        public Pinned_For_Users[] pinned_for_users { get; set; }
        public bool viewer_can_reshare { get; set; }
        public Edge_Sidecar_To_Children edge_sidecar_to_children { get; set; }
        public Dash_Info2 dash_info { get; set; }
        public bool has_audio { get; set; }
        public string tracking_token { get; set; }
        public string video_url { get; set; }
        public int video_view_count { get; set; }
        public object felix_profile_grid_crop { get; set; }
        public string product_type { get; set; }
        public Clips_Music_Attribution_Info clips_music_attribution_info { get; set; }
    }

    public class Dimensions1
    {
        public int height { get; set; }
        public int width { get; set; }
    }

    public class Edge_Media_To_Tagged_User1
    {
        public Edge3[] edges { get; set; }
    }

    public class Edge3
    {
        public Node3 node { get; set; }
    }

    public class Node3
    {
        public User2 user { get; set; }
        public float x { get; set; }
        public float y { get; set; }
    }

    public class User2
    {
        public string full_name { get; set; }
        public bool followed_by_viewer { get; set; }
        public string id { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
    }

    public class Sharing_Friction_Info1
    {
        public bool should_have_sharing_friction { get; set; }
        public object bloks_app_url { get; set; }
    }

    public class Owner1
    {
        public string id { get; set; }
        public string username { get; set; }
    }

    public class Edge_Media_To_Caption1
    {
        public Edge4[] edges { get; set; }
    }

    public class Edge4
    {
        public Node4 node { get; set; }
    }

    public class Node4
    {
        public string text { get; set; }
    }

    public class Edge_Media_To_Comment1
    {
        public int count { get; set; }
    }

    public class Edge_Liked_By1
    {
        public int count { get; set; }
    }

    public class Edge_Media_Preview_Like1
    {
        public int count { get; set; }
    }

    public class Edge_Sidecar_To_Children
    {
        public Edge5[] edges { get; set; }
    }

    public class Edge5
    {
        public Node5 node { get; set; }
    }

    public class Node5
    {
        public string __typename { get; set; }
        public string id { get; set; }
        public string shortcode { get; set; }
        public Dimensions2 dimensions { get; set; }
        public string display_url { get; set; }
        public Edge_Media_To_Tagged_User2 edge_media_to_tagged_user { get; set; }
        public object fact_check_overall_rating { get; set; }
        public object fact_check_information { get; set; }
        public object gating_info { get; set; }
        public Sharing_Friction_Info2 sharing_friction_info { get; set; }
        public object media_overlay_info { get; set; }
        public string media_preview { get; set; }
        public Owner2 owner { get; set; }
        public bool is_video { get; set; }
        public bool has_upcoming_event { get; set; }
        public string accessibility_caption { get; set; }
        public Dash_Info1 dash_info { get; set; }
        public bool has_audio { get; set; }
        public string tracking_token { get; set; }
        public string video_url { get; set; }
        public int video_view_count { get; set; }
    }

    public class Dimensions2
    {
        public int height { get; set; }
        public int width { get; set; }
    }

    public class Edge_Media_To_Tagged_User2
    {
        public Edge6[] edges { get; set; }
    }

    public class Edge6
    {
        public Node6 node { get; set; }
    }

    public class Node6
    {
        public User3 user { get; set; }
        public float x { get; set; }
        public float y { get; set; }
    }

    public class User3
    {
        public string full_name { get; set; }
        public bool followed_by_viewer { get; set; }
        public string id { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
    }

    public class Sharing_Friction_Info2
    {
        public bool should_have_sharing_friction { get; set; }
        public object bloks_app_url { get; set; }
    }

    public class Owner2
    {
        public string id { get; set; }
        public string username { get; set; }
    }

    public class Dash_Info1
    {
        public bool is_dash_eligible { get; set; }
        public object video_dash_manifest { get; set; }
        public int number_of_qualities { get; set; }
    }

    public class Dash_Info2
    {
        public bool is_dash_eligible { get; set; }
        public object video_dash_manifest { get; set; }
        public int number_of_qualities { get; set; }
    }

    public class Clips_Music_Attribution_Info
    {
        public string artist_name { get; set; }
        public string song_name { get; set; }
        public bool uses_original_audio { get; set; }
        public bool should_mute_audio { get; set; }
        public string should_mute_audio_reason { get; set; }
        public string audio_id { get; set; }
    }

    public class Thumbnail_Resources1
    {
        public string src { get; set; }
        public int config_width { get; set; }
        public int config_height { get; set; }
    }

    public class Pinned_For_Users
    {
        public string id { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
    }

    public class Edge_Saved_Media
    {
        public int count { get; set; }
        public Page_Info2 page_info { get; set; }
        public object[] edges { get; set; }
    }

    public class Page_Info2
    {
        public bool has_next_page { get; set; }
        public object end_cursor { get; set; }
    }

    public class Edge_Media_Collections
    {
        public int count { get; set; }
        public Page_Info3 page_info { get; set; }
        public object[] edges { get; set; }
    }

    public class Page_Info3
    {
        public bool has_next_page { get; set; }
        public object end_cursor { get; set; }
    }

    public class Edge_Related_Profiles
    {
        public Edge7[] edges { get; set; }
    }

    public class Edge7
    {
        public Node7 node { get; set; }
    }

    public class Node7
    {
        public string id { get; set; }
        public string full_name { get; set; }
        public bool is_private { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
    }

    public class Bio_Links
    {
        public string title { get; set; }
        public string lynx_url { get; set; }
        public string url { get; set; }
        public string link_type { get; set; }
    }

}
