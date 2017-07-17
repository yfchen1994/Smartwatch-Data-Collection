S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 30800
Date: 2017-07-09 19:00:55+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000001
r2   = 0x00000000, r3   = 0x00000001
r4   = 0x00000000, r5   = 0x419377fc
r6   = 0x00000000, r7   = 0xbebd3d30
r8   = 0x00000041, r9   = 0x40458824
r10  = 0x417b6210, fp   = 0x00000000
ip   = 0x404d9b50, sp   = 0xbebd3be8
lr   = 0x414c0be7, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   490112 KB
MemFree:     35736 KB
Buffers:     18984 KB
Cached:     123856 KB
VmPeak:     109832 KB
VmSize:     108816 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19400 KB
VmRSS:       19400 KB
VmData:      48152 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23268 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 30800 TID = 30800
30800 30914 30915 30916 30917 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f2000 40309000 r-xp /usr/lib/libecore.so.1.7.99
40320000 4037e000 r-xp /usr/lib/libedje.so.1.7.99
40388000 40458000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40459000 4045f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40467000 4046b000 r-xp /usr/lib/libsmack.so.1.0.0
40474000 4047c000 r-xp /lib/libgcc_s-4.6.so.1
4047d000 405a1000 r-xp /lib/libc-2.13.so
405af000 405cd000 r-xp /usr/lib/libsystemd.so.0.4.0
405d7000 405e2000 r-xp /lib/libunwind.so.8.0.1
4060f000 40626000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062e000 40658000 r-xp /usr/lib/libdbus-1.so.3.8.12
40661000 40666000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066e000 40691000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40699000 4069a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a2000 406a8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b1000 4071a000 r-xp /lib/libm-2.13.so
40723000 4073c000 r-xp /usr/lib/libeet.so.1.7.99
4074d000 4078e000 r-xp /usr/lib/libeina.so.1.7.99
40797000 407b9000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c2000 407c7000 r-xp /usr/lib/libecore_file.so.1.7.99
407cf000 407e0000 r-xp /usr/lib/libecore_input.so.1.7.99
407e8000 407f1000 r-xp /usr/lib/libvconf.so.0.2.45
407f9000 40849000 r-xp /usr/lib/libecore_x.so.1.7.99
4084b000 40854000 r-xp /usr/lib/libedbus.so.1.7.99
4085c000 40876000 r-xp /usr/lib/libecore_con.so.1.7.99
4087f000 40892000 r-xp /usr/lib/libfribidi.so.0.3.1
4089a000 408df000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a5a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a62000 40a65000 r-xp /lib/libcap.so.2.21
40a6d000 40a85000 r-xp /usr/lib/liblzma.so.5.0.3
40a8d000 40a9d000 r-xp /lib/libresolv-2.13.so
40aa1000 40b74000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b7f000 40bb3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbc000 40bd6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bde000 40c53000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5d000 40c5f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c67000 40c7d000 r-xp /lib/libz.so.1.2.5
40c85000 40ca8000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc0000 40da1000 r-xp /usr/lib/libX11.so.6.3.0
40dac000 40db1000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dba000 40dbe000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc7000 40dca000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd2000 40dd9000 r-xp /usr/lib/libXcursor.so.1.0.2
40de1000 40de3000 r-xp /usr/lib/libXdamage.so.1.1.0
40deb000 40ded000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df5000 40df7000 r-xp /usr/lib/libXgesture.so.7.0.0
40dff000 40e02000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0a000 40e13000 r-xp /usr/lib/libXi.so.6.1.0
40e1b000 40e1c000 r-xp /usr/lib/libXinerama.so.1.0.0
40e25000 40e2b000 r-xp /usr/lib/libXrandr.so.2.2.0
40e33000 40e39000 r-xp /usr/lib/libXrender.so.1.3.0
40e41000 40e45000 r-xp /usr/lib/libXtst.so.6.1.0
40e4d000 40e57000 r-xp /usr/lib/libXext.so.6.4.0
40e60000 40ea4000 r-xp /usr/lib/libcurl.so.4.3.0
40ead000 40ec3000 r-xp /lib/libexpat.so.1.6.0
40ecd000 40ee5000 r-xp /usr/lib/libpng12.so.0.50.0
40eed000 40f0a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f13000 40fa7000 r-xp /usr/lib/libstdc++.so.6.0.16
40fba000 40fbd000 r-xp /lib/libattr.so.1.1.0
40fc5000 40fc6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fce000 40fd3000 r-xp /usr/lib/libffi.so.5.0.10
40fdc000 40fde000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe6000 410b2000 r-xp /usr/lib/libxml2.so.2.7.8
410bf000 410c1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410ca000 410cc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d4000 410e7000 r-xp /usr/lib/libxcb.so.1.1.0
410f1000 410fa000 r-xp /usr/lib/libcares.so.2.1.0
41103000 41131000 r-xp /usr/lib/libidn.so.11.5.44
41139000 41180000 r-xp /usr/lib/libssl.so.1.0.0
4118c000 4131e000 r-xp /usr/lib/libcrypto.so.1.0.0
41340000 41342000 r-xp /usr/lib/libiri.so
4134a000 41351000 r-xp /lib/libcrypt-2.13.so
41381000 41383000 r-xp /usr/lib/libXau.so.6.0.0
41490000 41494000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4149c000 414a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
414a6000 414ab000 r-xp /usr/lib/libappcore-common.so.1.1
414b3000 414b5000 r-xp /usr/lib/libiniparser.so.0
414be000 414c1000 r-xp /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418bd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
418c8000 418d4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418dd000 418fe000 r-xp /usr/lib/libefl-extension.so.0.1.0
41906000 41930000 r-xp /usr/lib/libsensor.so.1.9.5
41939000 41940000 r-xp /usr/lib/libctx-shared.so.0.8.3
41948000 4194d000 r-xp /usr/lib/libctx-client.so.0.8.3
41955000 41967000 r-xp /usr/lib/libefl-assist.so.0.1.0
4196f000 41a27000 r-xp /usr/lib/libcairo.so.2.11200.14
41a32000 41a3c000 r-xp /usr/lib/libsensord-shared.so
41a44000 41a53000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a5c000 41a72000 r-xp /usr/lib/libtts.so
41a7b000 41a9e000 r-xp /usr/lib/libui-extension.so.0.1.0
41aa7000 41ab2000 r-xp /usr/lib/libtbm.so.1.0.0
41aba000 41ac8000 r-xp /usr/lib/libGLESv2.so.2.0
41ad1000 41ad2000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41adb000 41ae1000 r-xp /usr/lib/libxcb-render.so.0.0.0
41ae9000 41aec000 r-xp /usr/lib/libEGL.so.1.4
41af4000 41af9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41b01000 41b04000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b0c000 41b0d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41b16000 41c9e000 r-xp /usr/lib/libicui18n.so.57.1
41cae000 41db4000 r-xp /usr/lib/libicuuc.so.57.1
41dca000 41dd2000 r-xp /usr/lib/libdrm.so.2.4.0
41dda000 41ddc000 r-xp /usr/lib/libdri2.so.0.0.0
41de4000 41dea000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41df2000 41df7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41dff000 41e18000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
436b9000 436da000 r-xp /usr/lib/libexif.so.12.3.3
436ed000 436ef000 r-xp /usr/lib/libttrace.so.1.1
436f7000 436fc000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43704000 4370a000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43713000 4371b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43723000 43745000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4374e000 43755000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4375e000 43760000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43768000 4376f000 r-xp /usr/lib/libminizip.so.1.0.0
43777000 43784000 r-xp /usr/lib/libail.so.0.1.0
4378d000 43793000 r-xp /usr/lib/libproc-stat.so.0.2.96
4379b000 4379c000 r-xp /usr/lib/libresponse.so.0.2.96
437a4000 437a9000 r-xp /usr/lib/libsystem.so.0.0.0
437b3000 4387d000 r-xp /usr/lib/libCOREGL.so.4.0
43c22000 43c2d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c36000 43c3b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c43000 43c5a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c67000 43c69000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44571000 44572000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44636000 44e35000 rw-p [stack:30914]
44e36000 45635000 rw-p [stack:30915]
45636000 45e75000 rw-p [stack:30916]
46001000 46800000 rw-p [stack:30917]
bebb4000 bebd5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30800)
Call Stack Count: 17
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: _data_collection + 0x66 (0x414c0be7) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2be7
 2: _new_acceleartion_value + 0x8a (0x414c0a5f) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2a5f
 3: (0x418d1127) [/usr/lib/libcapi-system-sensor.so.0] + 0x9127
 4: (0x4191aaf0) [/usr/lib/libsensor.so.1] + 0x14af0
 5: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 6: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 7: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
 8: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
 9: (0x402fe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
10: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x116 (0x414bfb87) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1b87
14: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
15: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
16: create_base_gui + 0x157 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
End of Call Stack

Package Information
Package Name: org.example.sensordatacollection
Package ID : org.example.sensordatacollection
Version: 1.0.0
Package Type: rpm
App Name: sensordatacollection
App ID: org.example.sensordatacollection
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
o(com.samsung.w-home)
07-09 19:00:50.895+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 0
07-09 19:00:50.900+0800 W/AUL_AMD (  527): amd_launch.c: _start_app(1782) > caller pid : 866
07-09 19:00:50.905+0800 W/AUL     (  527): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(982) type(uiapp) bg(0)
07-09 19:00:50.905+0800 W/AUL_AMD (  527): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 982
07-09 19:00:50.905+0800 I/APP_CORE(  982): appcore-efl.c: __do_app(453) > [APP 982] Event: RESET State: RUNNING
07-09 19:00:50.905+0800 I/CAPI_APPFW_APPLICATION(  982): app_main.c: app_appcore_reset(245) > app_appcore_reset
07-09 19:00:50.905+0800 W/CAPI_APPFW_APP_CONTROL(  982): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
07-09 19:00:50.905+0800 E/W_HOME  (  982): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
07-09 19:00:50.905+0800 W/W_HOME  (  982): main.c: _app_control_progress(1568) > Service value : powerkey
07-09 19:00:50.905+0800 W/wnotib  (  982): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x40001
07-09 19:00:50.905+0800 E/wnotib  (  982): w-notification-board-action.c: wnb_action_is_popup_shown(4742) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-09 19:00:50.905+0800 E/wnotib  (  982): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-09 19:00:50.905+0800 W/wnotib  (  982): w-notification-board-broker-main.c: wnotib_main_dismiss_confirmation_popup(1427) > 
07-09 19:00:50.905+0800 W/W_HOME  (  982): noti_broker.c: _noti_broker_home_cb(779) > continue the home key execution
07-09 19:00:50.905+0800 E/W_HOME  (  982): cs_broker.c: _cs_broker_home_cb(274) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
07-09 19:00:50.905+0800 W/W_HOME  (  982): main.c: _home_key_cb(1466) > Home Key operation tutorial:0 window:1 clock:1 apps:0 is_app_resumed:1
07-09 19:00:50.905+0800 W/W_HOME  (  982): move.c: move_move_to_apps(216) > move to apps
07-09 19:00:50.905+0800 W/W_HOME  (  982): rotary.c: rotary_attach(138) > rotary_attach:0x49308e90
07-09 19:00:50.905+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x49308e90, elm_layout, _activated_obj : 0x460e3bb8, activated : 1
07-09 19:00:50.905+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-09 19:00:50.905+0800 W/W_HOME  (  982): event_manager.c: _move_module_anim_start_cb(666) > state: 0 -> 1
07-09 19:00:50.905+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 19:00:50.905+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 19:00:50.910+0800 W/W_INDICATOR(  867): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-09 19:00:50.910+0800 W/W_INDICATOR(  867): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-09 19:00:50.910+0800 W/AUL_AMD (  527): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(15), pid(982), cmd(0)
07-09 19:00:50.910+0800 W/AUL     (  866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(982)
07-09 19:00:50.910+0800 W/STARTER (  866): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [982]
07-09 19:00:50.910+0800 E/AUL     (  527): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-09 19:00:50.920+0800 W/APPS    (  982): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-09 19:00:50.925+0800 I/APP_CORE(  982): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
07-09 19:00:50.925+0800 W/W_HOME  (  982): event_manager.c: _apptray_visibility_cb(604) > apps,show,start
07-09 19:00:50.925+0800 W/W_HOME  (  982): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 0
07-09 19:00:50.930+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 19:00:50.930+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 19:00:50.930+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 19:00:50.930+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 19:00:50.930+0800 W/W_HOME  (  982): noti_broker.c: _apptray_visibility_cb(786) > apps,show,start
07-09 19:00:50.930+0800 W/W_HOME  (  982): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80002
07-09 19:00:50.930+0800 E/AUL     (  866): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-09 19:00:50.930+0800 W/wnotib  (  982): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80002
07-09 19:00:50.930+0800 I/wnotib  (  982): w-notification-board-broker-main.c: _wnotib_view_event_handler(1418) > Unhandled type: 0x80002
07-09 19:00:50.930+0800 W/W_INDICATOR(  867): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-09 19:00:50.930+0800 W/W_INDICATOR(  867): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-09 19:00:51.000+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 19:00:51.000+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 19:00:51.200+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 19:00:51.200+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 19:00:51.210+0800 W/W_HOME  (  982): event_manager.c: _move_module_anim_end_cb(680) > state: 1 -> 0
07-09 19:00:51.210+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 19:00:51.210+0800 W/W_HOME  (  982): rotary.c: rotary_deattach(156) > rotary_deattach:0x49308e90
07-09 19:00:51.210+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-09 19:00:51.210+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x49308e90, elm_layout, func : 0x4005653d
07-09 19:00:51.210+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-09 19:00:51.210+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-09 19:00:51.210+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-09 19:00:51.210+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e3bb8, elm_box, _activated_obj : 0x49308e90, activated : 1
07-09 19:00:51.210+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-09 19:00:51.210+0800 E/wnotib  (  982): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-09 19:00:51.210+0800 I/wnotib  (  982): w-notification-board-basic-panel.c: _wnb_basic_panel_passed_key_event_allow(6221) > Return true for 60, -1017.
07-09 19:00:51.210+0800 I/wnotib  (  982): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-09 19:00:51.215+0800 W/W_HOME  (  982): event_manager.c: _apptray_visibility_cb(604) > apps,show
07-09 19:00:51.215+0800 W/W_HOME  (  982): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 1
07-09 19:00:51.215+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:51.215+0800 W/W_INDICATOR(  867): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-09 19:00:51.215+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:51.215+0800 W/W_HOME  (  982): main.c: home_pause(546) > clock/widget paused
07-09 19:00:51.215+0800 W/W_INDICATOR(  867): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-09 19:00:51.215+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:51.215+0800 W/APPS    (  982): apps_main.c: _time_changed_cb(308) >  date : 9->9
07-09 19:00:51.220+0800 W/APPS    (  982): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-09 19:00:51.220+0800 W/W_HOME  (  982): rotary.c: rotary_attach(138) > rotary_attach:0x473695d8
07-09 19:00:51.220+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x473695d8, elm_layout, _activated_obj : 0x460e3bb8, activated : 1
07-09 19:00:51.220+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-09 19:00:51.220+0800 W/W_HOME  (  982): win.c: win_back_gesture_disable_set(170) > disable back gesture
07-09 19:00:51.220+0800 W/W_HOME  (  982): win.c: win_back_gesture_disable_set(170) > disable back gesture
07-09 19:00:51.220+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:51.220+0800 W/W_HOME  (  982): noti_broker.c: _apptray_visibility_cb(786) > apps,show
07-09 19:00:51.220+0800 W/W_HOME  (  982): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80000
07-09 19:00:51.220+0800 W/wnotib  (  982): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80000
07-09 19:00:51.220+0800 E/wnotib  (  982): w-notification-board-action.c: wnb_action_is_event_receivable(5112) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-09 19:00:51.220+0800 I/wnotib  (  982): w-notification-board-basic-panel.c: _wnb_basic_panel_close_second_depth_view(6300) > wnotib_action_drawer_is_event_receivable: 0, third_depth_genlist: (nil), _wnotib_basic_panel_is_third_depth_thread_view: 0, wnotib_common_is_toast_popup_displayed: 0
07-09 19:00:51.220+0800 E/wnotib  (  982): w-notification-board-action.c: wnb_action_is_event_receivable(5112) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-09 19:00:51.220+0800 I/wnotib  (  982): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 1
07-09 19:00:51.220+0800 W/wnotib  (  982): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [5], notiboard card appending count [6].
07-09 19:00:51.220+0800 E/APPS    (  982): apps_main.c: apps_main_resume(1003) >  resumed already
07-09 19:00:51.240+0800 W/WATCH_CORE( 1194): appcore-watch.c: __widget_pause(1113) > widget_pause
07-09 19:00:51.240+0800 W/AUL     ( 1194): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(1194) status(bg) type(watchapp)
07-09 19:00:51.240+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppPause(589) > 
07-09 19:00:51.830+0800 I/efl-extension( 1169): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-09 19:00:51.830+0800 I/efl-extension(  982): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-09 19:00:51.830+0800 I/efl-extension(  982): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473695d8, elm_layout, time_stamp : 35009423
07-09 19:00:51.830+0800 W/APPS    (  982): AppsViewNecklace.cpp: runRotaryForwardAnimation(3576) >  EditMode[0], focusPage[0], focusIndex[0], ItemListSize[34], FocusPrev[0], FocusNext[0], FocusRecent[1], HideNextPage[0]
07-09 19:00:51.830+0800 W/APPS    (  982): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[0], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-09 19:00:51.835+0800 W/APPS    (  982): AppsItem.cpp: aniFocusIndex(2351) >  [电话:0] Focused[0], focusIdx[0]
07-09 19:00:51.835+0800 W/APPS    (  982): AppsItem.cpp: setLastIndex(1264) >  This is last index app [33:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[0]
07-09 19:00:51.835+0800 W/APPS    (  982): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
07-09 19:00:51.840+0800 W/APPS    (  982): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-09 19:00:51.905+0800 W/AUL_AMD (  527): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-09 19:00:51.905+0800 W/AUL_AMD (  527): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
07-09 19:00:52.065+0800 W/APPS    (  982): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-09 19:00:52.830+0800 I/efl-extension( 1169): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-09 19:00:52.830+0800 I/efl-extension(  982): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-09 19:00:52.830+0800 I/efl-extension(  982): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x473695d8, elm_layout, time_stamp : 35010424
07-09 19:00:52.830+0800 W/APPS    (  982): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3697) >  EditMode[0], focusPage[0], focusIndex[0], ItemList size[34], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
07-09 19:00:52.830+0800 W/APPS    (  982): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[-1], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[1], HideNextPage[0], ItemListSize[34]
07-09 19:00:52.840+0800 W/APPS    (  982): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-09 19:00:53.055+0800 W/APPS    (  982): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-09 19:00:53.320+0800 E/EFL     (  982): ecore_x<982> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=35010911 button=1
07-09 19:00:53.320+0800 W/APPS    (  982): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [263, 74]
07-09 19:00:53.320+0800 E/W_HOME  (  982): util.c: util_is_rdu_retailmode(1372) > Cannot get the vconf for retailmode
07-09 19:00:53.385+0800 E/EFL     (  982): ecore_x<982> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=35010981 button=1
07-09 19:00:53.385+0800 W/APPS    (  982): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [263, 74]->[262, 95]
07-09 19:00:53.385+0800 E/APPS    (  982): AppsViewNecklace.cpp: __GetAppsItemByTouchIndex(6907) >  Can't Find AppsItem at [-1]
07-09 19:00:53.385+0800 W/APPS    (  982): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[0], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[1], HideNextPage[0], ItemListSize[34]
07-09 19:00:53.390+0800 E/APPS    (  982): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
07-09 19:00:53.390+0800 W/APPS    (  982): AppsViewNecklace.cpp: onClickedRecentApps(3232) >  item(WDS_TASKMGR_BUTTON2_RECENT_APPS_ABB) launched, open(0)
07-09 19:00:53.390+0800 W/AUL     (  982): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-taskmanager)
07-09 19:00:53.395+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 0
07-09 19:00:53.395+0800 W/AUL_AMD (  527): amd_launch.c: _start_app(1782) > caller pid : 982
07-09 19:00:53.395+0800 I/AUL_AMD (  527): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-09 19:00:53.410+0800 W/AUL_AMD (  527): amd_launch.c: _start_app(2218) > pad pid(-5)
07-09 19:00:53.410+0800 W/AUL_PAD ( 1157): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-09 19:00:53.410+0800 W/AUL_PAD ( 1157): launchpad.c: __send_result_to_caller(272) > Check app launching
07-09 19:00:53.415+0800 W/AUL     (30689): smack_util.c: set_app_smack_label(242) > thr_cnt: 2, signal count: 2,  try count 1, launchpad type: 1
07-09 19:00:53.415+0800 W/AUL_PAD (30689): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-09 19:00:53.415+0800 W/AUL_PAD (30689): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-09 19:00:53.415+0800 W/AUL_PAD (30689): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-09 19:00:53.415+0800 W/AUL_PAD (30689): launchpad_loader.c: main(680) > [candidate] dlopen(com.samsung.w-taskmanager)
07-09 19:00:53.425+0800 W/AUL_PAD (30689): launchpad_loader.c: main(690) > [candidate] dlsym
07-09 19:00:53.425+0800 W/AUL_PAD (30689): launchpad_loader.c: main(694) > [candidate] dl_main(com.samsung.w-taskmanager)
07-09 19:00:53.425+0800 I/CAPI_APPFW_APPLICATION(30689): app_main.c: app_efl_main(129) > app_efl_main
07-09 19:00:53.430+0800 I/CAPI_APPFW_APPLICATION(30689): app_main.c: app_appcore_create(152) > app_appcore_create
07-09 19:00:53.510+0800 W/AUL     (  527): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.w-taskmanager) pid(30689) type(uiapp) bg(0)
07-09 19:00:53.515+0800 W/AUL_AMD (  527): amd_status.c: __socket_monitor_cb(1277) > (30689) was created
07-09 19:00:53.515+0800 E/AUL     (  527): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-09 19:00:53.515+0800 W/AUL     (  982): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30689)
07-09 19:00:53.515+0800 W/W_HOME  (  982): util.c: apps_util_launch_main_operation(643) > Launch app:[WDS_TASKMGR_BUTTON2_RECENT_APPS_ABB] ret:[0]
07-09 19:00:53.520+0800 W/STARTER (  866): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [30689]
07-09 19:00:53.545+0800 I/efl-extension(30689): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-09 19:00:53.545+0800 I/efl-extension(30689): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-09 19:00:53.545+0800 I/efl-extension(30689): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-09 19:00:53.545+0800 I/efl-extension(30689): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-09 19:00:53.545+0800 I/efl-extension(30689): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-09 19:00:53.545+0800 I/efl-extension(30689): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4508c250, elm_image, _activated_obj : 0x0, activated : 1
07-09 19:00:53.580+0800 E/EFL     (30689): elementary<30689> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4506e9f0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-09 19:00:53.580+0800 E/EFL     (30689): elementary<30689> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4506e9f0 : elm_scroller] cw(360), ch(360), pw(360), ph(360)
07-09 19:00:53.580+0800 E/EFL     (30689): elementary<30689> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x4506e9f0 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
07-09 19:00:53.580+0800 E/EFL     (30689): elementary<30689> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4506e9f0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-09 19:00:53.580+0800 E/EFL     (30689): elementary<30689> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4506e9f0 : elm_scroller] cw(360), ch(360), pw(360), ph(360)
07-09 19:00:53.580+0800 E/EFL     (30689): elementary<30689> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x4506e9f0 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
07-09 19:00:53.600+0800 E/W_TASKMANAGER(30689): util_wc1.c: close_button_disabled_set(377) > [close_button_disabled_set:377] (ad->ly_main == NULL) -> close_button_disabled_set() return
07-09 19:00:53.640+0800 E/W_TASKMANAGER(30689): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
07-09 19:00:53.640+0800 E/W_TASKMANAGER(30689): taskmanager.c: _app_create(324) > [_app_create:324] cannot init pkgmgr
07-09 19:00:53.780+0800 I/capability-manager(30895): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
07-09 19:00:53.780+0800 I/capability-manager(30895): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
07-09 19:00:53.790+0800 E/W_TASKMANAGER(30689): task.c: _app_list_cb(609) > [_app_list_cb:609] pkgmgrinfo_appinfo_get_label(com.samsung.skmsa) failed(0)
07-09 19:00:53.790+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 12
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-home)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.watchface)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.shealth.widget.pedometer)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-calendar2.widget.monthly)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (health-data-service)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.wusvc)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-music-player.widget)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.shealth-service)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-music-player.music-control-service)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.watchface-service)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.message.consumer)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.weip.consumer)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.call.consumer)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-manager-service)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.wnotiboard-popup)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.weather-widget)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.gearstoresvc)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.weather-widget)!!
07-09 19:00:53.795+0800 E/W_TASKMANAGER(30689): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-taskmanager)!!
07-09 19:00:53.795+0800 E/RUA     (30689): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 36, ncols : 5
07-09 19:00:53.810+0800 E/EFL     (30689): evas_main<30689> evas_stack.c:158 evas_object_stack_above() BITCH! evas_object_stack_above(), 0x450f6ea8 not inside same smart as 0x450c79f0!
07-09 19:00:53.815+0800 E/EFL     (30689): elementary<30689> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x4509e408 into part 'elm.swallow.event.0'
07-09 19:00:53.845+0800 W/W_HOME  (  982): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-09 19:00:53.845+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:53.845+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:53.845+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:53.845+0800 W/W_HOME  (  982): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-09 19:00:53.845+0800 W/W_HOME  (  982): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-09 19:00:53.845+0800 W/W_INDICATOR(  867): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-09 19:00:53.845+0800 W/W_INDICATOR(  867): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-09 19:00:53.895+0800 I/APP_CORE(30689): appcore-efl.c: __do_app(453) > [APP 30689] Event: RESET State: CREATED
07-09 19:00:53.895+0800 I/CAPI_APPFW_APPLICATION(30689): app_main.c: app_appcore_reset(245) > app_appcore_reset
07-09 19:00:53.905+0800 I/APP_CORE(30689): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-09 19:00:53.905+0800 I/APP_CORE(30689): appcore-efl.c: __do_app(524) > [APP 30689] Initial Launching, call the resume_cb
07-09 19:00:53.905+0800 I/CAPI_APPFW_APPLICATION(30689): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-09 19:00:53.915+0800 W/APP_CORE(30689): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000003
07-09 19:00:53.930+0800 I/MALI    (30689): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-09 19:00:53.975+0800 W/W_HOME  (  982): event_manager.c: _window_visibility_cb(466) > Window [0x3600003] is now visible(1)
07-09 19:00:53.975+0800 W/W_HOME  (  982): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-09 19:00:53.975+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:53.975+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:53.975+0800 W/W_HOME  (  982): main.c: _window_visibility_cb(963) > Window [0x3600003] is now visible(1)
07-09 19:00:53.975+0800 I/APP_CORE(  982): appcore-efl.c: __do_app(453) > [APP 982] Event: PAUSE State: RUNNING
07-09 19:00:53.975+0800 I/CAPI_APPFW_APPLICATION(  982): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-09 19:00:53.975+0800 W/W_HOME  (  982): main.c: _appcore_pause_cb(487) > appcore pause
07-09 19:00:53.975+0800 W/W_HOME  (  982): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-09 19:00:53.975+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:53.980+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:53.980+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 19:00:53.980+0800 W/W_HOME  (  982): rotary.c: rotary_deattach(156) > rotary_deattach:0x473695d8
07-09 19:00:53.980+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-09 19:00:53.980+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x473695d8, elm_layout, func : 0x4005653d
07-09 19:00:53.980+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-09 19:00:53.980+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-09 19:00:53.980+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-09 19:00:53.980+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e3bb8, elm_box, _activated_obj : 0x473695d8, activated : 1
07-09 19:00:53.980+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-09 19:00:53.980+0800 E/wnotib  (  982): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-09 19:00:53.980+0800 I/wnotib  (  982): w-notification-board-basic-panel.c: _wnb_basic_panel_passed_key_event_allow(6221) > Return true for 60, -1017.
07-09 19:00:53.980+0800 I/wnotib  (  982): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-09 19:00:53.980+0800 W/W_INDICATOR(  867): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-09 19:00:53.980+0800 W/W_INDICATOR(  867): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-09 19:00:53.990+0800 W/STARTER (  866): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[982] goes to (4)
07-09 19:00:53.990+0800 W/AUL     (  527): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(982) status(bg) type(uiapp)
07-09 19:00:53.990+0800 E/STARTER (  866): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 982)'s state(4)
07-09 19:00:54.005+0800 W/STARTER (  866): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[30689] goes to (3)
07-09 19:00:54.005+0800 I/APP_CORE(30689): appcore-efl.c: __do_app(453) > [APP 30689] Event: RESUME State: RUNNING
07-09 19:00:54.005+0800 W/AUL     (  527): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(30689) status(fg) type(uiapp)
07-09 19:00:54.030+0800 W/W_HOME  (  982): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-09 19:00:54.035+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 19:00:54.035+0800 E/CAPI_APPFW_APP_CONTROL( 1326): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-09 19:00:54.035+0800 W/MUSIC_CONTROL_SERVICE( 1326): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1326]   [com.samsung.w-home]register msg port [false][0m
07-09 19:00:54.040+0800 I/wnotib  (  982): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-09 19:00:54.040+0800 E/wnotib  (  982): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-09 19:00:54.040+0800 W/wnotib  (  982): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [5], notiboard card appending count [6].
07-09 19:00:54.060+0800 W/APPS    (  982): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-09 19:00:54.375+0800 E/AUL     (  527): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-09 19:00:54.445+0800 I/MALI    (30689): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414600b8] swap changed from async to sync
07-09 19:00:54.540+0800 I/APP_CORE(  982): appcore-efl.c: __do_app(453) > [APP 982] Event: MEM_FLUSH State: PAUSED
07-09 19:00:54.695+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 14
07-09 19:00:54.705+0800 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30689
07-09 19:00:54.705+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 12
07-09 19:00:54.715+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 14
07-09 19:00:54.725+0800 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30689
07-09 19:00:54.730+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 12
07-09 19:00:55.025+0800 E/EFL     (30689): ecore_x<30689> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=35012620 button=1
07-09 19:00:55.025+0800 E/EFL     (30689): elementary<30689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4506e9f0 : elm_scroller] mouse move
07-09 19:00:55.035+0800 I/efl-extension(30900): efl_extension.c: eext_mod_init(40) > Init
07-09 19:00:55.035+0800 E/EFL     (30689): elementary<30689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4506e9f0 : elm_scroller] mouse move
07-09 19:00:55.035+0800 E/EFL     (30689): elementary<30689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4506e9f0 : elm_scroller] hold(0), freeze(0)
07-09 19:00:55.045+0800 E/EFL     (30689): ecore_x<30689> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=35012641 button=1
07-09 19:00:55.060+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 14
07-09 19:00:55.070+0800 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
07-09 19:00:55.070+0800 W/AUL     (30689): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-09 19:00:55.075+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 0
07-09 19:00:55.075+0800 W/AUL_AMD (  527): amd_launch.c: _start_app(1782) > caller pid : 30689
07-09 19:00:55.075+0800 I/AUL_AMD (  527): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-09 19:00:55.090+0800 W/AUL_AMD (  527): amd_launch.c: _start_app(2218) > pad pid(-5)
07-09 19:00:55.090+0800 W/AUL_PAD ( 1157): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-09 19:00:55.090+0800 W/AUL_PAD ( 1157): launchpad.c: __send_result_to_caller(272) > Check app launching
07-09 19:00:55.090+0800 W/AUL_PAD (30800): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-09 19:00:55.095+0800 E/RESOURCED(  627): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 8
07-09 19:00:55.100+0800 W/AUL_PAD (30800): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-09 19:00:55.100+0800 W/AUL_PAD (30800): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-09 19:00:55.100+0800 W/AUL_PAD (30800): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-09 19:00:55.130+0800 I/UXT     (30900): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-09 19:00:55.150+0800 I/efl-extension(30800): efl_extension.c: eext_mod_init(40) > Init
07-09 19:00:55.155+0800 I/UXT     (30800): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-09 19:00:55.160+0800 W/AUL_PAD (30800): launchpad_loader.c: main(690) > [candidate] dlsym
07-09 19:00:55.160+0800 W/AUL_PAD (30800): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-09 19:00:55.160+0800 I/CAPI_APPFW_APPLICATION(30800): app_main.c: ui_app_main(704) > app_efl_main
07-09 19:00:55.165+0800 I/CAPI_APPFW_APPLICATION(30800): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-09 19:00:55.190+0800 W/AUL     (  527): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(30800) type(uiapp) bg(0)
07-09 19:00:55.190+0800 W/AUL_AMD (  527): amd_status.c: __socket_monitor_cb(1277) > (30800) was created
07-09 19:00:55.190+0800 E/AUL     (  527): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-09 19:00:55.195+0800 W/AUL     (30689): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30800)
07-09 19:00:55.195+0800 E/W_TASKMANAGER(30689): task.c: taskmanager_launch_task_info(1075) > [taskmanager_launch_task_info:1075] _launch_app() failed(30800)
07-09 19:00:55.215+0800 W/STARTER (  866): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [30800]
07-09 19:00:55.260+0800 I/AUL_PAD (30900): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-09 19:00:55.285+0800 E/MALI    (30900): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-09 19:00:55.285+0800 E/MALI    (30900): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-09 19:00:55.285+0800 E/MALI    (30900): [gpu-ddk] devel/graphics_drv/r4p0
07-09 19:00:55.285+0800 E/MALI    (30900): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-09 19:00:55.285+0800 E/MALI    (30900): [coregl] devel/graphics_engine/master
07-09 19:00:55.285+0800 E/MALI    (30900): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-09 19:00:55.285+0800 E/MALI    (30900): 
07-09 19:00:55.355+0800 I/efl-extension(30800): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-09 19:00:55.355+0800 I/efl-extension(30800): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-09 19:00:55.355+0800 I/efl-extension(30800): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-09 19:00:55.355+0800 I/efl-extension(30800): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-09 19:00:55.355+0800 I/efl-extension(30800): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x417fbab8, elm_image, _activated_obj : 0x0, activated : 1
07-09 19:00:55.355+0800 E/EFL     (30800): elementary<30800> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-09 19:00:55.365+0800 E/EFL     (30800): elementary<30800> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x417fbf20) will be pushed
07-09 19:00:55.365+0800 I/efl-extension(30800): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x4447d5c8]'s widget[0x417fd3b0] to layout widget[0x417fbf20]
07-09 19:00:55.365+0800 E/EFL     (30800): elementary<30800> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e9500 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-09 19:00:55.365+0800 E/EFL     (30800): elementary<30800> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e9500 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-09 19:00:55.370+0800 I/efl-extension(30800): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-09 19:00:55.485+0800 I/MALI    (30689): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414600b8] swap changed from sync to async
07-09 19:00:55.485+0800 I/APP_CORE(30800): appcore-efl.c: __do_app(453) > [APP 30800] Event: RESET State: CREATED
07-09 19:00:55.490+0800 I/CAPI_APPFW_APPLICATION(30800): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-09 19:00:55.505+0800 I/APP_CORE(30800): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-09 19:00:55.505+0800 I/APP_CORE(30800): appcore-efl.c: __do_app(524) > [APP 30800] Initial Launching, call the resume_cb
07-09 19:00:55.510+0800 I/CAPI_APPFW_APPLICATION(30800): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-09 19:00:55.515+0800 W/APP_CORE(30800): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1000002
07-09 19:00:55.530+0800 E/EFL     (30800): elementary<30800> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e9500 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-09 19:00:55.530+0800 E/EFL     (30800): elementary<30800> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e9500 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-09 19:00:55.570+0800 E/EFL     (30800): elementary<30800> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e9500 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-09 19:00:55.570+0800 E/EFL     (30800): elementary<30800> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e9500 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-09 19:00:55.655+0800 W/AUL     (  527): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(30689) status(bg) type(uiapp)
07-09 19:00:55.655+0800 W/STARTER (  866): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[30689] goes to (4)
07-09 19:00:55.665+0800 W/STARTER (  866): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[30800] goes to (3)
07-09 19:00:55.665+0800 W/AUL     (  527): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(30800) status(fg) type(uiapp)
07-09 19:00:55.675+0800 I/APP_CORE(30800): appcore-efl.c: __do_app(453) > [APP 30800] Event: RESUME State: RUNNING
07-09 19:00:55.680+0800 I/APP_CORE(30689): appcore-efl.c: __do_app(453) > [APP 30689] Event: PAUSE State: RUNNING
07-09 19:00:55.680+0800 I/CAPI_APPFW_APPLICATION(30689): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-09 19:00:55.810+0800 W/CRASH_MANAGER(30792): worker.c: worker_job(1205) > 113080073656e149959805
