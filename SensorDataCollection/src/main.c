#include "main.h"
#include "sensorCollection.h"
#include "stdio.h"
#include "stdlib.h"
#include <time.h>
#include <device/haptic.h>
#include <sys/stat.h>
#include <sys/types.h>

const char ACC_MAIN_DIRECTORY[] = "/opt/usr/media/Downloads/yfchen_sensor_data/acc/";
const char GYR_MAIN_DIRECTORY[] = "/opt/usr/media/Downloads/yfchen_sensor_data/gyr/";

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *naviframe;
	Evas_Object *rect[10];
	Eext_Circle_Surface *circle_surface;
	Evas_Object *circle_genlist;
	Evas_Object *layout_waiting;
	Evas_Object *entry;
	char usr_str[256];
	char time_str[256];
	char name_to_delete[256];
} appdata_s;

Ecore_Timer* timer1;
Ecore_Timer* timer2;
Ecore_Timer* timer3;

/*
 * @brief Function will be operated when window deletion is requested
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @Ecore_Timer* timer1;
Ecore_Timer* timer2;
Ecore_Timer* timer3;param[in] event_info The system event information
 */
static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

/*
 * @brief Function to get absolute edje resource path
 * @param[in] edj_file_in The relative path of edje resource
 * @param[in] edj_path_out The pointer variable to write absolute path of edje resource
 * @param[in] edj_path_max The maximum size of path_out variable
 */
static void
app_get_resource(const char *edj_file_in, char *edj_path_out, int edj_path_max)
{
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(edj_path_out, edj_path_max, "%s%s", res_path, edj_file_in);
		free(res_path);
	}
}


/*
 * @brief Function will be operated when button is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */

static void time_str(appdata_s *data) {
    // Sensor collection
	appdata_s *ad = data;
	time_t raw_time;
	struct tm* time_info;
	time(&raw_time);
	time_info = localtime(&raw_time);
	sprintf(ad->time_str, "%d-%s%d-%d-%d-%s-%d", time_info->tm_year+1900, time_info->tm_mon<10? "0" : "", time_info->tm_mon+1,
		   time_info->tm_mday, time_info->tm_hour, time_info->tm_min<10? "0" : "", time_info->tm_min);
}

static void
_waiting_status_start_cb(void *data, Evas_Object *obj, void *event_info EINA_UNUSED)
{
	char edj_path[PATH_MAX] = {0, };
	appdata_s *ad = data;
	Evas_Object *naviframe = ad->naviframe;
	Evas_Object *layout = NULL;
	Evas_Object *label = NULL;
	Evas_Object *scroller = NULL;
	Evas_Object *circle_scroller = NULL;
	Elm_Object_Item *nf_it = NULL;

	dlog_print(DLOG_VERBOSE, "DATA_COLLECTION", "new page");

	app_get_resource(EDJ_FILE, edj_path, (int)PATH_MAX);

	layout = elm_layout_add(naviframe);
	elm_layout_file_set(layout, edj_path, "info_layout");
	evas_object_show(layout);

	scroller = elm_scroller_add(layout);
	evas_object_show(scroller);

	elm_object_part_content_set(layout, "elm.swallow.content", scroller);

	/* Create Circle Scroller */
	circle_scroller = eext_circle_object_scroller_add(scroller, ad->circle_surface);

	/* Set Scroller Policy */
	eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);

	label = elm_label_add(scroller);
	elm_label_line_wrap_set(label, ELM_WRAP_MIXED);
	elm_object_text_set(label, "<br/><br/>Collecting... :)<br/><br/><br/>");
	evas_object_show(label);

	elm_object_content_set(scroller, label);

	nf_it = elm_naviframe_item_push(naviframe, _("Slider"), NULL, NULL, layout, "empty");
}

static void
_waiting_status_end_cb(void *data) {
	appdata_s *ad = data;
	Evas_Object *naviframe = ad->naviframe;
	dlog_print(DLOG_VERBOSE, "DATA_COLLECTION_END", "delete new page");
	elm_naviframe_item_pop(naviframe);
}


/*
 * Deivce Vibration
 * */
static haptic_device_h device_handle;
static haptic_effect_h effect_handle;
static Eina_Bool _vibrate_cb_start(void *data) {
    ecore_timer_freeze(timer1);
    dlog_print(DLOG_VERBOSE, "FUNCTION_TAG", "vibrate_cb_start");
	int error = device_haptic_open(0, &device_handle);
	switch (error) {
		case DEVICE_ERROR_NONE: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Open: Successful!"); break;
		case DEVICE_ERROR_INVALID_PARAMETER: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Open: Invalid parameter"); break;
		case DEVICE_ERROR_PERMISSION_DENIED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Open: Permission denied"); break;
		case DEVICE_ERROR_OPERATION_FAILED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Open: Operation denied"); break;
		case DEVICE_ERROR_NOT_SUPPORTED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Open: Not supported device"); break;
	}
	static int vibrate_duration = 500;
	error = device_haptic_vibrate(device_handle, vibrate_duration, 100, &effect_handle);
	switch (error) {
		case DEVICE_ERROR_NONE: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Successful!"); break;
		case DEVICE_ERROR_INVALID_PARAMETER: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Invalid parameter"); break;
		case DEVICE_ERROR_PERMISSION_DENIED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Permission denied"); break;
		case DEVICE_ERROR_OPERATION_FAILED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Operation denied"); break;
		case DEVICE_ERROR_NOT_SUPPORTED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Not supported device"); break;
	}
	return 0;
}

static Eina_Bool _vibrate_cb_end(void *data) {
    ecore_timer_freeze(timer3);
    stop_data_collection();
    dlog_print(DLOG_VERBOSE, "FUNCTION_TAG", "vibrate_cb_end");
	int error = device_haptic_open(0, &device_handle);
	switch (error) {
		case DEVICE_ERROR_NONE: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Open: Successful!"); break;
		case DEVICE_ERROR_INVALID_PARAMETER: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Open: Invalid parameter"); break;
		case DEVICE_ERROR_PERMISSION_DENIED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Open: Permission denied"); break;
		case DEVICE_ERROR_OPERATION_FAILED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Open: Operation denied"); break;
		case DEVICE_ERROR_NOT_SUPPORTED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Open: Not supported device"); break;
	}
	static int vibrate_duration = 500;
	error = device_haptic_vibrate(device_handle, vibrate_duration, 100, &effect_handle);
	switch (error) {
		case DEVICE_ERROR_NONE: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Successful!"); break;
		case DEVICE_ERROR_INVALID_PARAMETER: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Invalid parameter"); break;
		case DEVICE_ERROR_PERMISSION_DENIED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Permission denied"); break;
		case DEVICE_ERROR_OPERATION_FAILED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Operation denied"); break;
		case DEVICE_ERROR_NOT_SUPPORTED: dlog_print(DLOG_VERBOSE, "VIBRATE_TAG", "Not supported device"); break;
	}
	_waiting_status_end_cb(data);
	return 0;
}

static Eina_Bool _start_data_collection_cb(void *data) {
	appdata_s *ad = data;
	dlog_print(DLOG_VERBOSE, "FUNCTION_TAG", "start_data_collection_cb");
	ecore_timer_freeze(timer2);
	char current_time_str[256];
	char usr_str_input[256];
	if(strlen(ad->usr_str) == 0 ) {
		strcpy(ad->usr_str, "admin");
	}
	strcpy(usr_str_input, ad->usr_str);
	dlog_print(DLOG_VERBOSE, "USR NAME: %s", usr_str_input);
	time_str(ad);
	strcpy(current_time_str, ad->time_str);
	start_data_collection(current_time_str, usr_str_input);
	_waiting_status_start_cb(ad, NULL, NULL);
	return 0;
}

static void
_button_clicked_cb_start(void *data, Evas_Object *obj, void *event_info)
{
	//elm_naviframe_item_pop(ad->naviframe);
	appdata_s *ad = data;
	dlog_print(DLOG_VERBOSE, "BUTTON_TAG", "start_click!");
	timer1 = ecore_timer_add(3, _vibrate_cb_start, NULL);
	timer2 = ecore_timer_add(3.5, _start_data_collection_cb, ad);
	timer3 = ecore_timer_add(13.5, _vibrate_cb_end, ad);

}


Evas_Object *to_del;
static void response_cb(void *data, Evas_Object *obj, void *event_info)
{
	if (to_del) {
		evas_object_del(to_del);
		to_del = NULL;
	}
	evas_object_del(obj);
}

void maxlength_reached(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *popup;
	Evas_Object *nf = (Evas_Object *)data;
	appdata_s *ad;
	if (to_del) return;

	ad = (appdata_s *)data;

	popup = elm_popup_add(nf);
	elm_object_style_set(popup, "toast/circle");
	elm_popup_orient_set(popup, ELM_POPUP_ORIENT_BOTTOM);
	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_popup_timeout_set(popup, 2.0);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, response_cb, NULL);
	evas_object_smart_callback_add(popup, "block,clicked", response_cb, NULL);
	evas_object_smart_callback_add(popup, "timeout", response_cb, NULL);
	elm_object_part_text_set(popup, "elm.text", "Maximum length reached");

	evas_object_show(popup);
	to_del = popup;
}

static void _entry_enter_click(void *data, Evas_Object *obj, void *event_info)
{
	printf("enter key clicked!!\n");
}

static void
_button_setting_cb(void *data) {
	dlog_print(DLOG_VERBOSE, "setting", "Setting begin");
	appdata_s *ad = data;
	char const * input_str = elm_entry_entry_get(ad->entry);
	strcpy(ad->usr_str, input_str);
	dlog_print(DLOG_VERBOSE, "setting", "%s", ad->usr_str);
	elm_naviframe_item_pop(ad->naviframe);
}

void _single_line_entry_cb(void *data, Evas_Object *obj, void *event_info)
{
	char edj_path[PATH_MAX] = {0, };
	appdata_s *ad = data;
	Evas_Object *naviframe = ad->naviframe;
	Evas_Object *layout = NULL;
	Evas_Object *label = NULL;
	Evas_Object *button = NULL;
	Evas_Object *scroller = NULL;
	Evas_Object *circle_scroller = NULL;
	Elm_Object_Item *nf_it = NULL;
	Elm_Object_Item *entry = NULL;
	static Elm_Entry_Filter_Limit_Size limit_filter_data;

	/* Unhighlight Item */
	elm_genlist_item_selected_set((Elm_Object_Item *)event_info, EINA_FALSE);
	app_get_resource(EDJ_FILE, edj_path, (int)PATH_MAX);

	layout = elm_layout_add(naviframe);
	elm_layout_file_set(layout, edj_path, "entry_layout");
	evas_object_show(layout);

	scroller = elm_scroller_add(layout);


	elm_object_part_content_set(layout, "elm.swallow.content", scroller);
	evas_object_show(scroller);

	entry = elm_entry_add(scroller);
	elm_entry_single_line_set(entry, EINA_TRUE);
	elm_entry_scrollable_set(entry, EINA_TRUE);
	elm_scroller_policy_set(entry, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	evas_object_smart_callback_add(entry, "maxlength,reached", maxlength_reached, naviframe);

	limit_filter_data.max_char_count = 0;
	limit_filter_data.max_byte_count = 100;
	elm_entry_markup_filter_append(entry, elm_entry_filter_limit_size, &limit_filter_data);
	elm_object_part_text_set(entry, "elm.guide", "Input your name");
	elm_entry_cursor_end_set(entry);
	evas_object_size_hint_weight_set(entry, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(entry, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_smart_callback_add(entry, "activated", _entry_enter_click, NULL);

	elm_object_part_content_set(layout, "entry_part", entry);
	elm_object_content_set(scroller, layout);

	button = elm_button_add(layout);
	elm_object_style_set(button, "bottom");
	elm_object_text_set(button, "OK");
	elm_object_part_content_set(layout, "elm.swallow.button", button);
	evas_object_show(button);

	ad->entry = entry;
	evas_object_smart_callback_add(button, "clicked", _button_setting_cb, ad);
	nf_it = elm_naviframe_item_push(naviframe, _("Slider"), NULL, NULL, layout, "empty");
}


static void
_data_collection_cb(void *data, Evas_Object *obj, void *event_info EINA_UNUSED)
{
	char edj_path[PATH_MAX] = {0, };
	appdata_s *ad = data;
	Evas_Object *naviframe = ad->naviframe;
	Evas_Object *layout = NULL;
	Evas_Object *label = NULL;
	Evas_Object *button_start = NULL;
	Evas_Object *scroller = NULL;
	Evas_Object *circle_scroller = NULL;
	Elm_Object_Item *nf_it = NULL;

	/* Unhighlight Item */
	elm_genlist_item_selected_set((Elm_Object_Item *)event_info, EINA_FALSE);

	app_get_resource(EDJ_FILE, edj_path, (int)PATH_MAX);

	layout = elm_layout_add(naviframe);
	elm_layout_file_set(layout, edj_path, "info_layout");
	evas_object_show(layout);

	scroller = elm_scroller_add(layout);
	evas_object_show(scroller);

	elm_object_part_content_set(layout, "elm.swallow.content", scroller);

	/* Create Circle Scroller */
	circle_scroller = eext_circle_object_scroller_add(scroller, ad->circle_surface);

	/* Set Scroller Policy */
	eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);

	label = elm_label_add(scroller);
	elm_label_line_wrap_set(label, ELM_WRAP_MIXED);
	elm_object_text_set(label, "<br/><br/>This is a sensor data collection application<br/><br/><br/>");
	evas_object_show(label);

	elm_object_content_set(scroller, label);

	button_start = elm_button_add(layout);
	elm_object_style_set(button_start, "bottom");
	elm_object_text_set(button_start, "Start");
	elm_object_part_content_set(layout, "elm.swallow.button", button_start);
	evas_object_smart_callback_add(button_start, "clicked", _button_clicked_cb_start, ad);
	evas_object_show(button_start);

	nf_it = elm_naviframe_item_push(naviframe, _("Slider"), NULL, NULL, layout, "empty");
}

static void
_delete_directory(char* directory) {
	char cmd[256];
	if (access(directory, 0) != -1) {
		strcpy(cmd, "chmod +R 777 ");
		strcat(cmd, directory);
		system(cmd);
		strcpy(cmd, "rm -r ");
		strcat(cmd, directory);
		system(cmd);
		dlog_print(DLOG_VERBOSE, "Delete directory", "Delete %s successfully!", directory);
	}
}

static void
_delete_name(void *data) {
	appdata_s *ad = data;
	if (strlen(ad->name_to_delete) == 0) {
		dlog_print(DLOG_VERBOSE, "Delete directory", "Null user name!");
		return;
	}

	char acc_directory_str[256];
	char gyr_directory_str[256];

	strcpy(acc_directory_str, ACC_MAIN_DIRECTORY);
	strcat(acc_directory_str, ad->name_to_delete);
	_delete_directory(acc_directory_str);

	strcpy(gyr_directory_str, GYR_MAIN_DIRECTORY);
	strcat(gyr_directory_str, ad->name_to_delete);
	_delete_directory(gyr_directory_str);
}

static void
_button_delete_cb(void *data) {
	dlog_print(DLOG_VERBOSE, "setting", "Setting begin");
	appdata_s *ad = data;
	char const * input_str = elm_entry_entry_get(ad->entry);
	strcpy(ad->name_to_delete, input_str);
	dlog_print(DLOG_VERBOSE, "Delete directory", "%s", ad->name_to_delete);
	_delete_name(ad);
	elm_naviframe_item_pop(ad->naviframe);
}

void _delete_user_cb(void *data, Evas_Object *obj, void *event_info)
{
	char edj_path[PATH_MAX] = {0, };
	appdata_s *ad = data;
	Evas_Object *naviframe = ad->naviframe;
	Evas_Object *layout = NULL;
	Evas_Object *label = NULL;
	Evas_Object *button = NULL;
	Evas_Object *scroller = NULL;
	Evas_Object *circle_scroller = NULL;
	Elm_Object_Item *nf_it = NULL;
	Elm_Object_Item *entry = NULL;
	static Elm_Entry_Filter_Limit_Size limit_filter_data;

	/* Unhighlight Item */
	elm_genlist_item_selected_set((Elm_Object_Item *)event_info, EINA_FALSE);
	app_get_resource(EDJ_FILE, edj_path, (int)PATH_MAX);

	layout = elm_layout_add(naviframe);
	elm_layout_file_set(layout, edj_path, "entry_layout");
	evas_object_show(layout);

	scroller = elm_scroller_add(layout);


	elm_object_part_content_set(layout, "elm.swallow.content", scroller);
	evas_object_show(scroller);

	entry = elm_entry_add(scroller);
	elm_entry_single_line_set(entry, EINA_TRUE);
	elm_entry_scrollable_set(entry, EINA_TRUE);
	elm_scroller_policy_set(entry, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	evas_object_smart_callback_add(entry, "maxlength,reached", maxlength_reached, naviframe);

	limit_filter_data.max_char_count = 0;
	limit_filter_data.max_byte_count = 100;
	elm_entry_markup_filter_append(entry, elm_entry_filter_limit_size, &limit_filter_data);
	elm_object_part_text_set(entry, "elm.guide", "File to delete");
	elm_entry_cursor_end_set(entry);
	evas_object_size_hint_weight_set(entry, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(entry, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_smart_callback_add(entry, "activated", _entry_enter_click, NULL);

	elm_object_part_content_set(layout, "entry_part", entry);
	elm_object_content_set(scroller, layout);

	button = elm_button_add(layout);
	elm_object_style_set(button, "bottom");
	elm_object_text_set(button, "OK");
	elm_object_part_content_set(layout, "elm.swallow.button", button);
	evas_object_show(button);

	ad->entry = entry;
	evas_object_smart_callback_add(button, "clicked", _button_delete_cb, ad);
	nf_it = elm_naviframe_item_push(naviframe, _("Slider"), NULL, NULL, layout, "empty");
}

char *main_menu_names[] = {
	"Basic Setting", "Data Collection", "Deleting User Data",
};

typedef struct _item_data {
	int index;
	Elm_Object_Item *item;
} item_data;

/*
 * @brief Function to get string on genlist title item's text part
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] part The name of text part
 * @param[out] char* A string with the characters to use as genlist title item's text part
 */
static char*
_gl_title_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];

	snprintf(buf, 1023, "%s", "Setting");

	return strdup(buf);
}

/*
 * @brief Function to get string on genlist item's text part
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] part The name of text part
 * @param[out] char* A string with the characters to use as genlist item's text part
 */
static char *
_gl_main_text_get(void *data, Evas_Object *obj, const char *part)
{
	char buf[1024];
	item_data *id = data;
	int index = id->index;

	if (!strcmp(part, "elm.text")) {
		snprintf(buf, 1023, "%s", main_menu_names[index]);
		return strdup(buf);
	}
	return NULL;
}

/*
 * @brief Function will be operated when genlist is deleted.
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 */
static void _gl_del(void *data, Evas_Object *obj)
{
	// FIXME: Unrealized callback can be called after this.
	// Accessing Item_Data can be dangerous on unrealized callback.
	item_data *id = data;
	if (id) free(id);
}

/*
 * @brief Function will be operated when naviframe pop its own item
 * @param[in] data The data to be passed to the callback function
 * @param[in] it The item to be popped from naviframe
 */
static Eina_Bool
_naviframe_pop_cb(void *data, Elm_Object_Item *it)
{
	ui_app_exit();
	return EINA_FALSE;
}

/*
 * @brief Function to create gui object
 * @param[in] ad The data structure to manage gui object
 */
static void
create_list_view(appdata_s *ad)
{
	Evas_Object *genlist = NULL;
	Evas_Object *naviframe = ad->naviframe;
	Elm_Object_Item *nf_it = NULL;
	Elm_Genlist_Item_Class *itc = elm_genlist_item_class_new();
	Elm_Genlist_Item_Class *titc = elm_genlist_item_class_new();
	Elm_Genlist_Item_Class *pitc = elm_genlist_item_class_new();
	item_data *id = NULL;
	int index = 0;

	/* Create Genlist */
	genlist = elm_genlist_add(naviframe);
	elm_genlist_mode_set(genlist, ELM_LIST_COMPRESS);
	evas_object_smart_callback_add(genlist, "selected", NULL, NULL);

	/* Create Circle Genlist */
	ad->circle_genlist = eext_circle_object_genlist_add(genlist, ad->circle_surface);

	/* Set Scroller Policy */
	eext_circle_object_genlist_scroller_policy_set(ad->circle_genlist, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

	/* Activate Rotary Event */
	eext_rotary_object_event_activated_set(ad->circle_genlist, EINA_TRUE);

	/* Genlist Item Style */
	itc->item_style = "default";
	itc->func.text_get = _gl_main_text_get;
	itc->func.del = _gl_del;

	/* Genlist Title Item Style */
	titc->item_style = "title";
	titc->func.text_get = _gl_title_text_get;
	titc->func.del = _gl_del;

	/* Genlist Padding Item Style */
	pitc->item_style = "padding";

	/* Title Item Here */
	elm_genlist_item_append(genlist, titc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);

	/* Main Menu Items Here */
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, _single_line_entry_cb, ad);
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, _data_collection_cb, ad);
	id = calloc(sizeof(item_data), 1);
	id->index = index++;
	id->item = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE, _delete_user_cb, ad);

	/* Padding Item Here */
	elm_genlist_item_append(genlist, pitc, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);

	nf_it = elm_naviframe_item_push(naviframe, NULL, NULL, NULL, genlist, "empty");
	elm_naviframe_item_pop_cb_set(nf_it, _naviframe_pop_cb, ad->win);
}





/*
 * @brief Function to create base gui structure
 * @param[in] ad The data structure to manage gui object
 */
static void
create_base_gui(appdata_s *ad)
{
	Evas_Object *conform = NULL;

	/* Window */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);

	/* Conformant */
	conform = elm_conformant_add(ad->win);
	evas_object_size_hint_weight_set(conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, conform);
	evas_object_show(conform);

	/* Naviframe */
	ad->naviframe = elm_naviframe_add(conform);
	elm_object_content_set(conform, ad->naviframe);

	/* Eext Circle Surface*/
	ad->circle_surface = eext_circle_surface_naviframe_add(ad->naviframe);

	/* Main View */
	create_list_view(ad);

	eext_object_event_callback_add(ad->naviframe, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);
	eext_object_event_callback_add(ad->naviframe, EEXT_CALLBACK_MORE, eext_naviframe_more_cb, NULL);
	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

/*
 * @brief Hook to take necessary actions before main event loop starts
 * Initialize UI resources and application's data
 * If this function return true, the main loop of application starts
 * If this function return false, the application is terminated
 * @param[in] user_data The data to be passed to the callback function
 */
static bool app_create(void *user_data)
{
	/* Hook to take necessary actions before main event loop starts
	   Initialize UI resources and application's data
	   If this function returns true, the main loop of application starts
	   If this function returns false, the application is terminated */
	appdata_s *ad = user_data;

	create_base_gui(ad);

	return true;
}

/*
 * @brief This callback function is called when another application
 * sends the launch request to the application
 * @param[in] app_control The handle to the app_control
 * @param[in] user_data The data to be passed to the callback function
 */
static void app_control(app_control_h app_control, void *user_data)
{
	/* Handle the launch request. */
}

/*
 * @brief This callback function is called each time
 * the application is completely obscured by another application
 * and becomes invisible to the user
 * @param[in] user_data The data to be passed to the callback function
 */
static void app_pause(void *user_data)
{
	/* Take necessary actions when application becomes invisible. */
}

/*
 * @brief This callback function is called each time
 * the application becomes visible to the user
 * @param[in] user_data The data to be passed to the callback function
 */
static void app_resume(void *user_data)
{
	/* Take necessary actions when application becomes visible. */
}

/*
 * @brief This callback function is called once after the main loop of the application exits
 * @param[in] user_data The data to be passed to the callback function
 */
static void app_terminate(void *user_data)
{
	/* Release all resources. */
}

/*
 * @brief This function will be called when the language is changed
 * @param[in] event_info The system event information
 * @param[in] user_data The user data to be passed to the callback function
 */
static void ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

/*
 * @brief This function will be called when the orientation is changed
 * @param[in] event_info The system event information
 * @param[in] user_data The user data to be passed to the callback function
 */
static void ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

/*
 * @brief This function will be called when the region is changed
 * @param[in] event_info The system event information
 * @param[in] user_data The user data to be passed to the callback function
 */
static void ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

/*
 * @brief This function will be called when the battery is low
 * @param[in] event_info The system event information
 * @param[in] user_data The user data to be passed to the callback function
 */
static void ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

/*
 * @brief This function will be called when the memory is low
 * @param[in] event_info The system event information
 * @param[in] user_data The user data to be passed to the callback function
 */
static void ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

/*
 * @brief Main function of the application
 * @param[in] argc The argument count
 * @param[in] argv The argument vector
 */
int main(int argc, char *argv[])
{
	appdata_s ad = {0, };
	int ret;

	ui_app_lifecycle_callback_s event_callback = {0, };
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE)
		dlog_print(DLOG_ERROR, LOG_TAG, "ui_app_main() is failed. err = %d", ret);

	return ret;
}
