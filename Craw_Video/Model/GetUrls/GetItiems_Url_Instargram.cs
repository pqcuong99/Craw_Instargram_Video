using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craw_Video.Model.GetUrls
{
    public class GetItiems_Url_Instargram
    {
        public Item[] items { get; set; }
        public Paging_Info paging_info { get; set; }
        public string status { get; set; }
    }

    public class Paging_Info
    {
        public string max_id { get; set; }
        public bool more_available { get; set; }
    }

    public class Item
    {
        public Media media { get; set; }
    }

    public class Media
    {
        public int taken_at { get; set; }
        public string pk { get; set; }
        public string id { get; set; }
        public long device_timestamp { get; set; }
        public string client_cache_key { get; set; }
        public int filter_type { get; set; }
        public bool caption_is_edited { get; set; }
        public bool like_and_view_counts_disabled { get; set; }
        public string strong_id__ { get; set; }
        public bool is_reshare_of_text_post_app_media_in_ig { get; set; }
        public bool is_post_live_clips_media { get; set; }
        public int deleted_reason { get; set; }
        public string integrity_review_decision { get; set; }
        public int has_shared_to_fb { get; set; }
        public bool is_unified_video { get; set; }
        public bool should_request_ads { get; set; }
        public bool is_visual_reply_commenter_notice_enabled { get; set; }
        public string commerciality_status { get; set; }
        public bool explore_hide_comments { get; set; }
        public bool comment_threading_enabled { get; set; }
        public bool has_delayed_metadata { get; set; }
        public int view_state_item_type { get; set; }
        public string logging_info_token { get; set; }
        public Clips_Delivery_Parameters clips_delivery_parameters { get; set; }
        public string mezql_token { get; set; }
        public Usertags usertags { get; set; }
        public bool photo_of_you { get; set; }
        public object shop_routing_user_id { get; set; }
        public bool can_see_insights_as_brand { get; set; }
        public bool is_organic_product_tagging_eligible { get; set; }
        public bool has_liked { get; set; }
        public bool has_privately_liked { get; set; }
        public int like_count { get; set; }
        public int media_type { get; set; }
        public string code { get; set; }
        public bool can_viewer_reshare { get; set; }
        public Caption caption { get; set; }
        public object[] clips_tab_pinned_user_ids { get; set; }
        public Comment_Inform_Treatment comment_inform_treatment { get; set; }
        public Sharing_Friction_Info sharing_friction_info { get; set; }
        public int play_count { get; set; }
        public Media_Appreciation_Settings media_appreciation_settings { get; set; }
        public bool original_media_has_visual_reply_media { get; set; }
        public Fb_User_Tags fb_user_tags { get; set; }
        public object[] invited_coauthor_producers { get; set; }
        public bool can_viewer_save { get; set; }
        public bool is_in_profile_grid { get; set; }
        public bool profile_grid_control_enabled { get; set; }
        public bool is_comments_gif_composer_enabled { get; set; }
        public Highlights_Info highlights_info { get; set; }
        public Media_Cropping_Info media_cropping_info { get; set; }
        public object[] product_suggestions { get; set; }
        public User2 user { get; set; }
        public Image_Versions2 image_versions2 { get; set; }
        public int original_width { get; set; }
        public int original_height { get; set; }
        public bool is_artist_pick { get; set; }
        public bool enable_media_notes_production { get; set; }
        public string product_type { get; set; }
        public bool is_paid_partnership { get; set; }
        public object music_metadata { get; set; }
        public string organic_tracking_token { get; set; }
        public bool is_third_party_downloads_eligible { get; set; }
        public bool ig_media_sharing_disabled { get; set; }
        public bool are_remixes_crosspostable { get; set; }
        public object boost_unavailable_identifier { get; set; }
        public object boost_unavailable_reason { get; set; }
        public string open_carousel_submission_state { get; set; }
        public bool is_open_to_public_submission { get; set; }
        public int max_num_visible_preview_comments { get; set; }
        public bool has_more_comments { get; set; }
        public object[] preview_comments { get; set; }
        public object[] comments { get; set; }
        public int comment_count { get; set; }
        public bool can_view_more_preview_comments { get; set; }
        public bool hide_view_all_comment_entrypoint { get; set; }
        public bool is_auto_created { get; set; }
        public bool is_cutout_sticker_allowed { get; set; }
        public bool is_reuse_allowed { get; set; }
        public bool enable_waist { get; set; }
        public Owner owner { get; set; }
        public Video_Versions[] video_versions { get; set; }
        public float video_duration { get; set; }
        public bool has_audio { get; set; }
        public Clips_Metadata clips_metadata { get; set; }
        public string[] crosspost { get; set; }
        public bool is_sidecar_child { get; set; }
        public Liker[] likers { get; set; }
        public int view_count { get; set; }
        public string preview { get; set; }
    }

    public class Clips_Delivery_Parameters
    {
    }

    public class Usertags
    {
        public In[] _in { get; set; }
    }

    public class In
    {
        public User user { get; set; }
        public float[] position { get; set; }
        public object start_time_in_video_in_sec { get; set; }
        public object duration_in_video_in_sec { get; set; }
    }

    public class User
    {
        public string pk { get; set; }
        public string pk_id { get; set; }
        public string id { get; set; }
        public string username { get; set; }
        public string full_name { get; set; }
        public bool is_private { get; set; }
        public string strong_id__ { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
    }

    public class Caption
    {
        public string pk { get; set; }
        public string user_id { get; set; }
        public User1 user { get; set; }
        public int type { get; set; }
        public string text { get; set; }
        public bool did_report_as_spam { get; set; }
        public int created_at { get; set; }
        public int created_at_utc { get; set; }
        public string content_type { get; set; }
        public string status { get; set; }
        public int bit_flags { get; set; }
        public bool share_enabled { get; set; }
        public bool is_ranked_comment { get; set; }
        public bool is_covered { get; set; }
        public int private_reply_status { get; set; }
        public string media_id { get; set; }
    }

    public class User1
    {
        public string fbid_v2 { get; set; }
        public bool feed_post_reshare_disabled { get; set; }
        public string full_name { get; set; }
        public string id { get; set; }
        public bool is_private { get; set; }
        public bool is_unpublished { get; set; }
        public string pk { get; set; }
        public string pk_id { get; set; }
        public bool show_account_transparency_details { get; set; }
        public string strong_id__ { get; set; }
        public int third_party_downloads_enabled { get; set; }
        public string username { get; set; }
        public object[] account_badges { get; set; }
        public Fan_Club_Info fan_club_info { get; set; }
        public bool has_anonymous_profile_picture { get; set; }
        public Hd_Profile_Pic_Url_Info hd_profile_pic_url_info { get; set; }
        public Hd_Profile_Pic_Versions[] hd_profile_pic_versions { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
        public bool transparency_product_enabled { get; set; }
    }

    public class Fan_Club_Info
    {
        public object fan_club_id { get; set; }
        public object fan_club_name { get; set; }
        public object is_fan_club_referral_eligible { get; set; }
        public object fan_consideration_page_revamp_eligiblity { get; set; }
        public object is_fan_club_gifting_eligible { get; set; }
        public object subscriber_count { get; set; }
        public object connected_member_count { get; set; }
        public object autosave_to_exclusive_highlight { get; set; }
        public object has_enough_subscribers_for_ssc { get; set; }
    }

    public class Hd_Profile_Pic_Url_Info
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Hd_Profile_Pic_Versions
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Comment_Inform_Treatment
    {
        public bool should_have_inform_treatment { get; set; }
        public string text { get; set; }
        public object url { get; set; }
        public object action_type { get; set; }
    }

    public class Sharing_Friction_Info
    {
        public bool should_have_sharing_friction { get; set; }
        public object bloks_app_url { get; set; }
        public object sharing_friction_payload { get; set; }
    }

    public class Media_Appreciation_Settings
    {
        public string media_gifting_state { get; set; }
        public string gift_count_visibility { get; set; }
    }

    public class Fb_User_Tags
    {
        public object[] _in { get; set; }
    }

    public class Highlights_Info
    {
        public object[] added_to { get; set; }
    }

    public class Media_Cropping_Info
    {
        public Square_Crop square_crop { get; set; }
    }

    public class Square_Crop
    {
        public float crop_left { get; set; }
        public float crop_right { get; set; }
        public float crop_top { get; set; }
        public float crop_bottom { get; set; }
    }

    public class User2
    {
        public string fbid_v2 { get; set; }
        public bool feed_post_reshare_disabled { get; set; }
        public string full_name { get; set; }
        public string id { get; set; }
        public bool is_private { get; set; }
        public bool is_unpublished { get; set; }
        public string pk { get; set; }
        public string pk_id { get; set; }
        public bool show_account_transparency_details { get; set; }
        public string strong_id__ { get; set; }
        public int third_party_downloads_enabled { get; set; }
        public string username { get; set; }
        public object[] account_badges { get; set; }
        public Fan_Club_Info1 fan_club_info { get; set; }
        public bool has_anonymous_profile_picture { get; set; }
        public Hd_Profile_Pic_Url_Info1 hd_profile_pic_url_info { get; set; }
        public Hd_Profile_Pic_Versions1[] hd_profile_pic_versions { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
        public bool transparency_product_enabled { get; set; }
    }

    public class Fan_Club_Info1
    {
        public object fan_club_id { get; set; }
        public object fan_club_name { get; set; }
        public object is_fan_club_referral_eligible { get; set; }
        public object fan_consideration_page_revamp_eligiblity { get; set; }
        public object is_fan_club_gifting_eligible { get; set; }
        public object subscriber_count { get; set; }
        public object connected_member_count { get; set; }
        public object autosave_to_exclusive_highlight { get; set; }
        public object has_enough_subscribers_for_ssc { get; set; }
    }

    public class Hd_Profile_Pic_Url_Info1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Hd_Profile_Pic_Versions1
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Image_Versions2
    {
        public Candidate[] candidates { get; set; }
        public Additional_Candidates additional_candidates { get; set; }
        public bool smart_thumbnail_enabled { get; set; }
        public Scrubber_Spritesheet_Info_Candidates scrubber_spritesheet_info_candidates { get; set; }
    }

    public class Additional_Candidates
    {
        public Igtv_First_Frame igtv_first_frame { get; set; }
        public First_Frame first_frame { get; set; }
        public object smart_frame { get; set; }
    }

    public class Igtv_First_Frame
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class First_Frame
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Scrubber_Spritesheet_Info_Candidates
    {
        public Default _default { get; set; }
    }

    public class Default
    {
        public float video_length { get; set; }
        public int thumbnail_width { get; set; }
        public int thumbnail_height { get; set; }
        public float thumbnail_duration { get; set; }
        public string[] sprite_urls { get; set; }
        public int thumbnails_per_row { get; set; }
        public int total_thumbnail_num_per_sprite { get; set; }
        public int max_thumbnails_per_sprite { get; set; }
        public int sprite_width { get; set; }
        public int sprite_height { get; set; }
        public int rendered_width { get; set; }
        public int file_size_kb { get; set; }
    }

    public class Candidate
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Owner
    {
        public string fbid_v2 { get; set; }
        public bool feed_post_reshare_disabled { get; set; }
        public string full_name { get; set; }
        public string id { get; set; }
        public bool is_private { get; set; }
        public bool is_unpublished { get; set; }
        public string pk { get; set; }
        public string pk_id { get; set; }
        public bool show_account_transparency_details { get; set; }
        public string strong_id__ { get; set; }
        public int third_party_downloads_enabled { get; set; }
        public string username { get; set; }
        public object[] account_badges { get; set; }
        public Fan_Club_Info2 fan_club_info { get; set; }
        public bool has_anonymous_profile_picture { get; set; }
        public Hd_Profile_Pic_Url_Info2 hd_profile_pic_url_info { get; set; }
        public Hd_Profile_Pic_Versions2[] hd_profile_pic_versions { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
        public bool transparency_product_enabled { get; set; }
    }

    public class Fan_Club_Info2
    {
        public object fan_club_id { get; set; }
        public object fan_club_name { get; set; }
        public object is_fan_club_referral_eligible { get; set; }
        public object fan_consideration_page_revamp_eligiblity { get; set; }
        public object is_fan_club_gifting_eligible { get; set; }
        public object subscriber_count { get; set; }
        public object connected_member_count { get; set; }
        public object autosave_to_exclusive_highlight { get; set; }
        public object has_enough_subscribers_for_ssc { get; set; }
    }

    public class Hd_Profile_Pic_Url_Info2
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Hd_Profile_Pic_Versions2
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Clips_Metadata
    {
        public Music_Info music_info { get; set; }
        public Original_Sound_Info original_sound_info { get; set; }
        public string audio_type { get; set; }
        public string music_canonical_id { get; set; }
        public object featured_label { get; set; }
        public Mashup_Info mashup_info { get; set; }
        public object reusable_text_info { get; set; }
        public object reusable_text_attribute_string { get; set; }
        public object nux_info { get; set; }
        public object viewer_interaction_settings { get; set; }
        public Branded_Content_Tag_Info branded_content_tag_info { get; set; }
        public object shopping_info { get; set; }
        public Additional_Audio_Info additional_audio_info { get; set; }
        public bool is_shared_to_fb { get; set; }
        public object breaking_content_info { get; set; }
        public object challenge_info { get; set; }
        public object reels_on_the_rise_info { get; set; }
        public object breaking_creator_info { get; set; }
        public object asset_recommendation_info { get; set; }
        public object contextual_highlight_info { get; set; }
        public string clips_creation_entry_point { get; set; }
        public Audio_Ranking_Info audio_ranking_info { get; set; }
        public object template_info { get; set; }
        public object is_fan_club_promo_video { get; set; }
        public bool disable_use_in_clips_client_cache { get; set; }
        public Content_Appreciation_Info content_appreciation_info { get; set; }
        public Achievements_Info achievements_info { get; set; }
        public bool show_achievements { get; set; }
        public object show_tips { get; set; }
        public object merchandising_pill_info { get; set; }
        public bool is_public_chat_welcome_video { get; set; }
        public int professional_clips_upsell_type { get; set; }
        public object external_media_info { get; set; }
        public object[] cutout_sticker_info { get; set; }
    }

    public class Music_Info
    {
        public Music_Asset_Info music_asset_info { get; set; }
        public Music_Consumption_Info music_consumption_info { get; set; }
        public object music_canonical_id { get; set; }
    }

    public class Music_Asset_Info
    {
        public string audio_cluster_id { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public object sanitized_title { get; set; }
        public string subtitle { get; set; }
        public string display_artist { get; set; }
        public string artist_id { get; set; }
        public string cover_artwork_uri { get; set; }
        public string cover_artwork_thumbnail_uri { get; set; }
        public string progressive_download_url { get; set; }
        public object reactive_audio_download_url { get; set; }
        public string fast_start_progressive_download_url { get; set; }
        public string web_30s_preview_download_url { get; set; }
        public int[] highlight_start_times_in_ms { get; set; }
        public bool is_explicit { get; set; }
        public object dash_manifest { get; set; }
        public bool has_lyrics { get; set; }
        public string audio_asset_id { get; set; }
        public int duration_in_ms { get; set; }
        public object dark_message { get; set; }
        public bool allows_saving { get; set; }
        public string ig_username { get; set; }
        public bool is_eligible_for_audio_effects { get; set; }
    }

    public class Music_Consumption_Info
    {
        public Ig_Artist ig_artist { get; set; }
        public string placeholder_profile_pic_url { get; set; }
        public bool should_mute_audio { get; set; }
        public string should_mute_audio_reason { get; set; }
        public object should_mute_audio_reason_type { get; set; }
        public bool is_bookmarked { get; set; }
        public int overlap_duration_in_ms { get; set; }
        public int audio_asset_start_time_in_ms { get; set; }
        public bool allow_media_creation_with_music { get; set; }
        public bool is_trending_in_clips { get; set; }
        public object trend_rank { get; set; }
        public object formatted_clips_media_count { get; set; }
        public object display_labels { get; set; }
        public bool should_allow_music_editing { get; set; }
        public object derived_content_id { get; set; }
        public object[] audio_filter_infos { get; set; }
        public Audio_Muting_Info audio_muting_info { get; set; }
        public object contains_lyrics { get; set; }
        public bool should_render_soundwave { get; set; }
    }

    public class Ig_Artist
    {
        public string pk { get; set; }
        public string pk_id { get; set; }
        public string username { get; set; }
        public string id { get; set; }
        public string full_name { get; set; }
        public bool is_private { get; set; }
        public string strong_id__ { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
    }

    public class Audio_Muting_Info
    {
        public bool mute_audio { get; set; }
        public string mute_reason_str { get; set; }
        public bool allow_audio_editing { get; set; }
        public bool show_muted_audio_toast { get; set; }
    }

    public class Original_Sound_Info
    {
        public string audio_asset_id { get; set; }
        public object music_canonical_id { get; set; }
        public string progressive_download_url { get; set; }
        public int duration_in_ms { get; set; }
        public string dash_manifest { get; set; }
        public Ig_Artist1 ig_artist { get; set; }
        public bool should_mute_audio { get; set; }
        public bool hide_remixing { get; set; }
        public string original_media_id { get; set; }
        public int time_created { get; set; }
        public string original_audio_title { get; set; }
        public Consumption_Info consumption_info { get; set; }
        public bool can_remix_be_shared_to_fb { get; set; }
        public bool can_remix_be_shared_to_fb_expansion { get; set; }
        public object formatted_clips_media_count { get; set; }
        public bool allow_creator_to_rename { get; set; }
        public object[] audio_parts { get; set; }
        public object[] audio_parts_by_filter { get; set; }
        public bool is_explicit { get; set; }
        public string original_audio_subtype { get; set; }
        public bool is_audio_automatically_attributed { get; set; }
        public bool is_reuse_disabled { get; set; }
        public bool is_xpost_from_fb { get; set; }
        public object xpost_fb_creator_info { get; set; }
        public bool is_original_audio_download_eligible { get; set; }
        public object trend_rank { get; set; }
        public object[] audio_filter_infos { get; set; }
        public bool oa_owner_is_music_artist { get; set; }
        public bool is_eligible_for_audio_effects { get; set; }
    }

    public class Ig_Artist1
    {
        public string pk { get; set; }
        public string pk_id { get; set; }
        public string username { get; set; }
        public string full_name { get; set; }
        public bool is_private { get; set; }
        public string strong_id__ { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
    }

    public class Consumption_Info
    {
        public bool is_bookmarked { get; set; }
        public string should_mute_audio_reason { get; set; }
        public bool is_trending_in_clips { get; set; }
        public object should_mute_audio_reason_type { get; set; }
        public object display_media_id { get; set; }
    }

    public class Mashup_Info
    {
        public bool mashups_allowed { get; set; }
        public bool can_toggle_mashups_allowed { get; set; }
        public bool has_been_mashed_up { get; set; }
        public bool is_light_weight_check { get; set; }
        public object formatted_mashups_count { get; set; }
        public object original_media { get; set; }
        public object privacy_filtered_mashups_media_count { get; set; }
        public int? non_privacy_filtered_mashups_media_count { get; set; }
        public object mashup_type { get; set; }
        public bool is_creator_requesting_mashup { get; set; }
        public bool has_nonmimicable_additional_audio { get; set; }
        public bool is_pivot_page_available { get; set; }
    }

    public class Branded_Content_Tag_Info
    {
        public bool can_add_tag { get; set; }
    }

    public class Additional_Audio_Info
    {
        public object additional_audio_username { get; set; }
        public Audio_Reattribution_Info audio_reattribution_info { get; set; }
    }

    public class Audio_Reattribution_Info
    {
        public bool should_allow_restore { get; set; }
    }

    public class Audio_Ranking_Info
    {
        public string best_audio_cluster_id { get; set; }
    }

    public class Content_Appreciation_Info
    {
        public bool enabled { get; set; }
        public object entry_point_container { get; set; }
    }

    public class Achievements_Info
    {
        public bool show_achievements { get; set; }
        public object num_earned_achievements { get; set; }
    }

    public class Video_Versions
    {
        public int type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
        public string id { get; set; }
    }

    public class Liker
    {
        public string pk { get; set; }
        public string pk_id { get; set; }
        public string username { get; set; }
        public string full_name { get; set; }
        public bool is_private { get; set; }
        public string strong_id__ { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_id { get; set; }
        public string profile_pic_url { get; set; }
    }

}
