S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 25114
Date: 2017-07-10 18:19:25+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x413d145c
r2   = 0x413d12b4, r3   = 0x00000001
r4   = 0x00000000, r5   = 0x413c1091
r6   = 0x413c0ee3, r7   = 0xbefa4208
r8   = 0x41ed290b, r9   = 0x0000621a
r10  = 0x4004e7e8, fp   = 0x00000000
ip   = 0x404d9b50, sp   = 0xbefa3f20
lr   = 0x413c0ae9, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:      9616 KB
Buffers:     20208 KB
Cached:     126148 KB
VmPeak:      74260 KB
VmSize:      74260 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15136 KB
VmRSS:       15136 KB
VmData:      14264 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23272 KB
VmPTE:          48 KB
VmSwap:          0 KB

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
41390000 41394000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4139c000 413a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
413a6000 413ab000 r-xp /usr/lib/libappcore-common.so.1.1
413b3000 413b5000 r-xp /usr/lib/libiniparser.so.0
413be000 413c2000 r-xp /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
413d4000 413d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e1000 413e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ec000 413f2000 r-xp /usr/lib/libappsvc.so.0.1.0
413fa000 4141e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41427000 414f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4150c000 41516000 r-xp /lib/libnss_files-2.13.so
416b2000 416bd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
416c8000 416d4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
416dd000 416fe000 r-xp /usr/lib/libefl-extension.so.0.1.0
41706000 41730000 r-xp /usr/lib/libsensor.so.1.9.5
41739000 41740000 r-xp /usr/lib/libctx-shared.so.0.8.3
41748000 4174d000 r-xp /usr/lib/libctx-client.so.0.8.3
41755000 41767000 r-xp /usr/lib/libefl-assist.so.0.1.0
4176f000 41827000 r-xp /usr/lib/libcairo.so.2.11200.14
41832000 4183c000 r-xp /usr/lib/libsensord-shared.so
41844000 41853000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
4185c000 41872000 r-xp /usr/lib/libtts.so
4187b000 4189e000 r-xp /usr/lib/libui-extension.so.0.1.0
418a7000 418b2000 r-xp /usr/lib/libtbm.so.1.0.0
418ba000 418c8000 r-xp /usr/lib/libGLESv2.so.2.0
418d1000 418d2000 r-xp /usr/lib/libxcb-shm.so.0.0.0
418db000 418e1000 r-xp /usr/lib/libxcb-render.so.0.0.0
418e9000 418ec000 r-xp /usr/lib/libEGL.so.1.4
418f4000 418f9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41901000 41904000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4190c000 4190d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41916000 41a9e000 r-xp /usr/lib/libicui18n.so.57.1
41aae000 41bb4000 r-xp /usr/lib/libicuuc.so.57.1
41bca000 41bd2000 r-xp /usr/lib/libdrm.so.2.4.0
41bda000 41bdc000 r-xp /usr/lib/libdri2.so.0.0.0
41be4000 41bea000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41bf2000 41bf7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41bff000 41c18000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41c20000 41c41000 r-xp /usr/lib/libexif.so.12.3.3
41c54000 41c56000 r-xp /usr/lib/libttrace.so.1.1
41c5e000 41c63000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41c6b000 41c71000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41c7a000 41c82000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41c8a000 41cac000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41cb5000 41cbc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41cc5000 41cc7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41ccf000 41cd6000 r-xp /usr/lib/libminizip.so.1.0.0
41cde000 41ceb000 r-xp /usr/lib/libail.so.0.1.0
41cf4000 41cfa000 r-xp /usr/lib/libproc-stat.so.0.2.96
41d02000 41d03000 r-xp /usr/lib/libresponse.so.0.2.96
41d0b000 41d10000 r-xp /usr/lib/libsystem.so.0.0.0
41d1a000 41de4000 r-xp /usr/lib/libCOREGL.so.4.0
41df6000 41e01000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41e0a000 41e0f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41e17000 41e19000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41e25000 41e28000 rw-p [heap]
41e28000 41f5c000 rw-p [heap]
43b88000 43b9f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
444ac000 444ad000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
bef84000 befa5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25114)
Call Stack Count: 11
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: start_data_collection + 0x110 (0x413c0ae9) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2ae9
 2: create_base_gui + 0x152 (0x413bfe77) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e77
 3: app_create + 0x12 (0x413bfc6f) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1c6f
 4: (0x413919c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 5: appcore_efl_main + 0x246 (0x40044a5b) [/usr/lib/libappcore-efl.so.1] + 0x3a5b
 6: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: main + 0x116 (0x413bfbf7) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1bf7
 8: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
 9: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
10: create_base_gui + 0xe7 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
t visibility : 0
07-10 18:19:04.523+0800 W/W_HOME  (  824): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
07-10 18:19:04.528+0800 W/AUL_PAD (24748): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
07-10 18:19:04.533+0800 W/W_INDICATOR(  760): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-10 18:19:04.553+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-10 18:19:04.573+0800 W/W_HOME  (  824): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(0)
07-10 18:19:04.578+0800 W/W_HOME  (  824): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
07-10 18:19:04.578+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:19:04.578+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:19:04.578+0800 W/W_HOME  (  824): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(0)
07-10 18:19:04.578+0800 I/APP_CORE(  824): appcore-efl.c: __do_app(453) > [APP 824] Event: RESUME State: PAUSED
07-10 18:19:04.578+0800 I/CAPI_APPFW_APPLICATION(  824): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-10 18:19:04.578+0800 W/W_HOME  (  824): main.c: _appcore_resume_cb(478) > appcore resume
07-10 18:19:04.583+0800 W/W_HOME  (  824): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
07-10 18:19:04.583+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:19:04.583+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:19:04.583+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:19:04.583+0800 W/APPS    (  824): apps_main.c: _time_changed_cb(308) >  date : 10->10
07-10 18:19:04.583+0800 W/APPS    (  824): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-10 18:19:04.588+0800 W/W_HOME  (  824): rotary.c: rotary_attach(138) > rotary_attach:0x473287a0
07-10 18:19:04.588+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x473287a0, elm_layout, _activated_obj : 0x460e3b10, activated : 1
07-10 18:19:04.588+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-10 18:19:04.588+0800 W/W_HOME  (  824): win.c: win_back_gesture_disable_set(170) > disable back gesture
07-10 18:19:04.588+0800 W/W_HOME  (  824): win.c: win_back_gesture_disable_set(170) > disable back gesture
07-10 18:19:04.588+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:19:04.593+0800 I/wnotib  (  824): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
07-10 18:19:04.593+0800 E/wnotib  (  824): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-10 18:19:04.593+0800 W/wnotib  (  824): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
07-10 18:19:04.598+0800 W/W_INDICATOR(  760): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-10 18:19:04.598+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-10 18:19:04.603+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
07-10 18:19:04.608+0800 E/PKGMGR_SERVER(24935): pkgmgr-server.c: req_cb(1154) > CHECK_KILL_APP done[return = 0] 
07-10 18:19:04.708+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 24748 pgid = 24748
07-10 18:19:04.708+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
07-10 18:19:04.753+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:19:04.758+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24748
07-10 18:19:04.758+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24748)
07-10 18:19:05.088+0800 I/MALI    (  824): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43ecf218] swap changed from async to sync
07-10 18:19:05.558+0800 W/AUL_AMD (  518): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
07-10 18:19:05.583+0800 E/PKGMGR_SERVER(24935): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-10 18:19:05.583+0800 E/PKGMGR_SERVER(24935): pkgmgr-server.c: main(2296) > package manager server terminated.
07-10 18:19:05.593+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:19:05.598+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:19:05.603+0800 E/CAPI_APPFW_APP_CONTROL( 1013): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-10 18:19:05.603+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1013]   [com.samsung.w-home]register msg port [true][0m
07-10 18:19:05.603+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:19:05.648+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 3159
07-10 18:19:05.648+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:05.653+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:19:05.673+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 824
07-10 18:19:05.688+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1013]   [MUSIC_PLAYER_EVENT][0m
07-10 18:19:05.688+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:05.688+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:19:05.693+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:05.693+0800 W/W_HOME  (  824): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
07-10 18:19:05.693+0800 E/W_HOME  (  824): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
07-10 18:19:05.693+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1013]   [MUSIC_PLAYER_EVENT][0m
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:05.698+0800 W/W_HOME  (  824): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
07-10 18:19:05.698+0800 E/W_HOME  (  824): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:19:05.698+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:19:11.843+0800 E/PKGMGR  (25047): pkgmgr.c: pkgmgr_client_reinstall(1940) > reinstall pkg start.
07-10 18:19:12.043+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: main(2242) > package manager server start
07-10 18:19:12.153+0800 E/PKGMGR  (25049): pkgmgr-internal.c: _get_type_from_zip(735) > can not access to [org.example.sensordatacollection]
07-10 18:19:12.153+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: __get_type_from_msg(335) > pkgtype is null for org.example.sensordatacollection 
07-10 18:19:12.158+0800 E/PKGMGR_SERVER(25049): pm-mdm.c: _get_package_info_from_file(1146) > [0;31m[_get_package_info_from_file(): 1146](ret < 0) access() failed. path: org.example.sensordatacollection errno: 2 (No such file or directory)[0;m
07-10 18:19:12.158+0800 E/PKGMGR_SERVER(25050): pkgmgr-server.c: queue_job(1944) > INSTALL start, pkg path=[org.example.sensordatacollection]
07-10 18:19:12.168+0800 E/PKGMGR_SERVER(25051): pkgmgr-server.c: queue_job(2138) > COMM_REQ_OBSERVER start, pkgid=[]
07-10 18:19:12.168+0800 E/PKGMGR  (25047): pkgmgr.c: pkgmgr_client_reinstall(2052) > reinstall pkg finish, ret=[250470002]
07-10 18:19:12.263+0800 E/rpm-installer(25050): rpm-appcore-intf.c: main(120) > ------------------------------------------------
07-10 18:19:12.263+0800 E/rpm-installer(25050): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
07-10 18:19:12.263+0800 E/rpm-installer(25050): rpm-appcore-intf.c: main(122) > ------------------------------------------------
07-10 18:19:12.288+0800 E/PKGMGR_OBSERVER(25051): pkg_observer.c: main(601) > OBSERVER start
07-10 18:19:12.523+0800 E/PKGMGR_OBSERVER(25051): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[250510002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[start] val[update]
07-10 18:19:12.553+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(start), value(update)
07-10 18:19:12.553+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(997) > __amd_pkgmgrinfo_start_handler
07-10 18:19:12.558+0800 E/PKGMGR_OBSERVER(25051): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[250510002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[30]
07-10 18:19:12.563+0800 W/W_HOME  (  824): clock_event.c: _pkgmgr_event_cb(210) > Pkg:org.example.sensordatacollection is being updateded:0
07-10 18:19:12.578+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [UPDATE, STARTED]
07-10 18:19:12.598+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [UPDATE, PROCESSING]
07-10 18:19:12.693+0800 W/CERT_SVC(25050): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
07-10 18:19:12.703+0800 E/rpm-installer(25050): coretpk-parser.c: _coretpk_parser_get_manifest_info(1751) > (doc == NULL) xmlParseFile() failed.
07-10 18:19:12.703+0800 E/rpm-installer(25050): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
07-10 18:19:12.703+0800 E/rpm-installer(25050): coretpk-installer.c: _coretpk_installer_package_reinstall(6741) > _coretpk_installer_verify_privilege_list failed
07-10 18:19:12.718+0800 E/PKGMGR_PARSER(25050): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
07-10 18:19:12.798+0800 E/rpm-installer(25050): coretpk-installer.c: _coretpk_installer_package_reinstall(6795) > _coretpk_installer_package_reinstall(org.example.sensordatacollection) failed.
07-10 18:19:12.808+0800 E/PKGMGR_OBSERVER(25051): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[250510002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[end] val[fail]
07-10 18:19:12.813+0800 E/PKGMGR_OBSERVER(25051): pkg_observer.c: main(620) > OBSERVER end
07-10 18:19:12.828+0800 E/APPS    (  824): pkgmgr.c: _end(777) >  (strcasecmp(val, "ok")) -> _end() return
07-10 18:19:12.828+0800 E/APPS    (  824): pkgmgr.c: _pkgmgr_cb(840) >  pkgmgr_cbs[6].func has errors.
07-10 18:19:12.843+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(end), value(fail)
07-10 18:19:12.858+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: sighandler(486) > child NORMAL exit [25051]
07-10 18:19:12.858+0800 E/STARTER (  759): pkg-monitor.c: _pkg_monitor_get_mainappid(105) > [_pkg_monitor_get_mainappid:105] Failed to get pkginfo[-1]
07-10 18:19:12.923+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [UPDATE, COMPLETED]
07-10 18:19:12.923+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
07-10 18:19:12.923+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-10 18:19:12.923+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-10 18:19:14.583+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 18:19:14.688+0800 E/rpm-installer(25050): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-10 18:19:14.688+0800 E/rpm-installer(25050): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-10 18:19:14.688+0800 E/rpm-installer(25050): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-10 18:19:14.723+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: sighandler(486) > child NORMAL exit [25050]
07-10 18:19:14.743+0800 E/RESOURCED(  635): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/25050/oom_score_adj failed
07-10 18:19:14.743+0800 E/RESOURCED(  635): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 25050
07-10 18:19:16.018+0800 E/PKGMGR  (25100): pkgmgr.c: pkgmgr_client_install(1651) > install pkg start.
07-10 18:19:16.078+0800 E/PKGMGR  (25049): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk is core
07-10 18:19:16.078+0800 E/PKGMGR  (25049): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk is core
07-10 18:19:16.083+0800 E/rpm-installer(25049): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
07-10 18:19:16.088+0800 E/BACKEND_LIB(25049): librpm.c: __is_symlink_file(70) > file is safe
07-10 18:19:16.098+0800 E/PKGMGR_SERVER(25049): pm-mdm.c: _pm_check_mdm_policy(1063) > [0;31m[_pm_check_mdm_policy(): 1063](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
07-10 18:19:16.103+0800 E/PKGMGR  (25100): pkgmgr.c: pkgmgr_client_install(1768) > install pkg finish, ret=[251000002]
07-10 18:19:16.108+0800 E/PKGMGR_SERVER(25102): pkgmgr-server.c: queue_job(1944) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk]
07-10 18:19:16.113+0800 E/PKGMGR_SERVER(25103): pkgmgr-server.c: queue_job(2138) > COMM_REQ_OBSERVER start, pkgid=[]
07-10 18:19:16.203+0800 E/rpm-installer(25102): rpm-appcore-intf.c: main(120) > ------------------------------------------------
07-10 18:19:16.203+0800 E/rpm-installer(25102): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
07-10 18:19:16.203+0800 E/rpm-installer(25102): rpm-appcore-intf.c: main(122) > ------------------------------------------------
07-10 18:19:16.228+0800 E/PKGMGR_OBSERVER(25103): pkg_observer.c: main(601) > OBSERVER start
07-10 18:19:16.348+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-10 18:19:16.358+0800 E/rpm-installer(25102): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk] is tpk package.
07-10 18:19:16.368+0800 E/rpm-installer(25102): coretpk-parser.c: __coretpk_parser_get_value(1713) > (result_value == NULL) [install-location] is empty.
07-10 18:19:16.368+0800 E/rpm-installer(25102): coretpk-parser.c: __coretpk_parser_get_value_list(1670) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
07-10 18:19:16.373+0800 E/rpm-installer(25102): coretpk-parser.c: _coretpk_parser_is_widget(1586) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget'])
07-10 18:19:16.373+0800 E/rpm-installer(25102): coretpk-parser.c: _coretpk_parser_is_custom_clock(1480) > (ret == 1) metadata(watchface) is empty.
07-10 18:19:16.373+0800 E/rpm-installer(25102): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.sensordatacollection/) failed. [2][No such file or directory]
07-10 18:19:16.373+0800 E/rpm-installer(25102): coretpk-installer.c: _coretpk_installer_install_package(3579) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.sensordatacollection/]
07-10 18:19:16.473+0800 E/PKGMGR_OBSERVER(25103): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[251030002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[start] val[install]
07-10 18:19:16.483+0800 E/APPS    (  824): pkgmgr.c: _start(495) >  (_exist_request_in_list(package)) -> _start() return
07-10 18:19:16.483+0800 E/APPS    (  824): pkgmgr.c: _pkgmgr_cb(840) >  pkgmgr_cbs[0].func has errors.
07-10 18:19:16.503+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(start), value(install)
07-10 18:19:16.508+0800 E/PKGMGR_OBSERVER(25103): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[251030002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[30]
07-10 18:19:16.528+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, STARTED]
07-10 18:19:16.548+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 18:19:16.583+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 18:19:16.638+0800 W/CERT_SVC(25102): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
07-10 18:19:16.658+0800 E/rpm-installer(25102): coretpk-parser.c: __coretpk_parser_verify_metadata(48) > (ret == 1) metadata is empty.
07-10 18:19:16.663+0800 E/rpm-installer(25102): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
07-10 18:19:16.663+0800 E/rpm-installer(25102): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
07-10 18:19:16.663+0800 E/rpm-installer(25102): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(541) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
07-10 18:19:16.743+0800 E/PKGMGR_PARSER(25102): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2167) > Manifest is Valid
07-10 18:19:16.743+0800 E/PKGMGR_PARSER(25102): pkgmgr_parser.c: __parse_manifest_for_installation(1910) > parsing manifest for installation: /opt/share/packages/org.example.sensordatacollection.xml
07-10 18:19:16.748+0800 E/PKGMGR_PARSER(25102): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
07-10 18:19:16.748+0800 E/PKGMGR_PARSER(25102): pkgmgr_parser.c: __ps_process_tag(866) > tag is NULL
07-10 18:19:16.903+0800 I/efl-extension(25102): efl_extension.c: eext_mod_init(40) > Init
07-10 18:19:16.908+0800 I/efl-extension(25102): efl_extension.c: eext_mod_shutdown(46) > Shutdown
07-10 18:19:16.998+0800 E/PKGMGR_PARSER(25102): pkgmgr_parser.c: __parse_manifest_for_installation(1952) > parsing manifest for installation Done
07-10 18:19:17.028+0800 E/PKGMGR_CERT(25102): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
07-10 18:19:17.028+0800 E/PKGMGR_CERT(25102): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 120
07-10 18:19:17.028+0800 E/PKGMGR_CERT(25102): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 120
07-10 18:19:17.033+0800 E/PKGMGR_CERT(25102): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 29 6
07-10 18:19:17.033+0800 E/PKGMGR_CERT(25102): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 21 14
07-10 18:19:17.033+0800 E/PKGMGR_CERT(25102): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 14
07-10 18:19:17.033+0800 E/PKGMGR_CERT(25102): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 30 6
07-10 18:19:17.048+0800 E/PKGMGR_CERT(25102): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(575) > Transaction Commit and End
07-10 18:19:17.058+0800 E/PKGMGR_OBSERVER(25103): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[251030002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[60]
07-10 18:19:17.113+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 18:19:17.123+0800 E/rpm-installer(25102): installer-util.c: _installer_util_get_configuration_value(601) > [signature]=[on]
07-10 18:19:17.133+0800 E/rpm-installer(25102): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [z0QlgvtZWc7MUAsAHX1kZCd6NyfN6kalPinZVqoqrqE=] for shared/trusted.
07-10 18:19:17.153+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 24848 pgid = 24848
07-10 18:19:17.153+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-10 18:19:17.253+0800 E/rpm-installer(25102): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
07-10 18:19:17.288+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24848
07-10 18:19:17.288+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24848)
07-10 18:19:17.318+0800 E/PKGMGR_OBSERVER(25103): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[251030002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[100]
07-10 18:19:17.323+0800 E/rpm-installer(25102): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
07-10 18:19:17.368+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 18:19:17.413+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:19:17.413+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 24749 pgid = -1
07-10 18:19:17.413+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-10 18:19:17.413+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:19:17.423+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24749
07-10 18:19:17.423+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24749)
07-10 18:19:17.493+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24747
07-10 18:19:17.493+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24747)
07-10 18:19:18.373+0800 I/AUL_PAD (25114): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 18:19:18.583+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 18:19:18.958+0800 W/MM_CAMCORDER(25113): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
07-10 18:19:18.958+0800 W/MM_CAMCORDER(25113): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
07-10 18:19:18.968+0800 I/efl-extension(25113): efl_extension.c: eext_mod_init(40) > Init
07-10 18:19:19.173+0800 I/efl-extension(25115): efl_extension.c: eext_mod_init(40) > Init
07-10 18:19:19.253+0800 I/UXT     (25115): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:19:19.478+0800 E/PKGMGR_OBSERVER(25103): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[251030002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[end] val[ok]
07-10 18:19:19.483+0800 W/W_HOME  (  824): clock_event.c: _pkgmgr_event_cb(247) > Pkg:org.example.sensordatacollection is updated, need to check validation
07-10 18:19:19.483+0800 W/W_HOME  (  824): clock_event.c: _pkgmgr_event_cb(251) > attacheck clock:com.samsung.watchface
07-10 18:19:19.513+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(end), value(ok)
07-10 18:19:19.518+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, COMPLETED]
07-10 18:19:19.518+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
07-10 18:19:19.518+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-10 18:19:19.518+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-10 18:19:19.518+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_package_install_event(5061) > triggered from Gear itself.
07-10 18:19:19.588+0800 E/WMS     (  516): wms_db.c: wms_db_package_event_insert_record(190) > 
07-10 18:19:19.603+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2887) > send_install_response completed : END
07-10 18:19:19.608+0800 E/STARTER (  759): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
07-10 18:19:19.613+0800 E/PKGMGR_INFO(25103): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
07-10 18:19:19.628+0800 E/PKGMGR_INFO(  513): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-10 18:19:19.633+0800 W/SVOICE  ( 3159): DomainAppState.cpp: operator()(64) > [0;32mINFO: Apps info changed. SetUploadSyncCondition[0;m
07-10 18:19:19.633+0800 W/SVOICE  ( 3159): PreferenceKey.cpp: SetUploadSyncCondition(551) > [0;32mINFO: UploadManager need to Sync : 1[0;m
07-10 18:19:19.643+0800 E/PKGMGR_OBSERVER(25103): pkg_observer.c: main(620) > OBSERVER end
07-10 18:19:19.668+0800 W/APPS    (  824): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
07-10 18:19:19.678+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: sighandler(486) > child NORMAL exit [25103]
07-10 18:19:19.708+0800 I/AUL_PAD (25115): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 18:19:19.738+0800 E/MALI    (25115): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-10 18:19:19.738+0800 E/MALI    (25115): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-10 18:19:19.738+0800 E/MALI    (25115): [gpu-ddk] devel/graphics_drv/r4p0
07-10 18:19:19.738+0800 E/MALI    (25115): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-10 18:19:19.738+0800 E/MALI    (25115): [coregl] devel/graphics_engine/master
07-10 18:19:19.738+0800 E/MALI    (25115): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-10 18:19:19.738+0800 E/MALI    (25115): 
07-10 18:19:20.448+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.478+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.483+0800 E/AUL     (25113): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:19:20.483+0800 E/AUL     (25113): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:19:20.513+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.538+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.538+0800 E/AUL     (25113): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:19:20.538+0800 E/AUL     (25113): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:19:20.578+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.583+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 18:19:20.593+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.593+0800 E/AUL     (25113): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:19:20.593+0800 E/AUL     (25113): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:19:20.603+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.618+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.618+0800 E/AUL     (25113): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:19:20.618+0800 E/AUL     (25113): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:19:20.633+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.653+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.653+0800 E/AUL     (25113): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:19:20.653+0800 E/AUL     (25113): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:19:20.668+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.683+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.683+0800 E/AUL     (25113): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:19:20.683+0800 E/AUL     (25113): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:19:20.698+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.713+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.713+0800 E/AUL     (25113): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:19:20.713+0800 E/AUL     (25113): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:19:20.728+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.738+0800 I/AUL     (25113): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:20.738+0800 E/AUL     (25113): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:19:20.738+0800 E/AUL     (25113): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:19:20.773+0800 I/UXT     (25113): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:19:20.898+0800 E/MALI    (25113): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-10 18:19:20.903+0800 E/MALI    (25113): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-10 18:19:20.903+0800 E/MALI    (25113): [gpu-ddk] devel/graphics_drv/r4p0
07-10 18:19:20.903+0800 E/MALI    (25113): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-10 18:19:20.903+0800 E/MALI    (25113): [coregl] devel/graphics_engine/master
07-10 18:19:20.903+0800 E/MALI    (25113): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-10 18:19:20.903+0800 E/MALI    (25113): K
07-10 18:19:21.663+0800 I/MALI    (25113): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-10 18:19:21.668+0800 E/MALI    (25113): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-10 18:19:21.693+0800 I/AUL     (25124): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-10 18:19:21.728+0800 I/AUL     (25124): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:19:21.728+0800 E/AUL     (25124): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:19:21.728+0800 E/AUL     (25124): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:19:21.788+0800 E/rpm-installer(25102): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-10 18:19:21.788+0800 E/rpm-installer(25102): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-10 18:19:21.788+0800 E/rpm-installer(25102): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-10 18:19:21.803+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: sighandler(486) > child NORMAL exit [25102]
07-10 18:19:21.863+0800 E/RESOURCED(  635): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/25102/oom_score_adj failed
07-10 18:19:21.863+0800 E/RESOURCED(  635): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 25102
07-10 18:19:22.583+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-10 18:19:22.588+0800 E/PKGMGR_SERVER(25049): pkgmgr-server.c: main(2296) > package manager server terminated.
07-10 18:19:25.218+0800 W/AUL     (25204): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 18:19:25.223+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 18:19:25.258+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-10 18:19:25.278+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-10 18:19:25.278+0800 E/AUL_AMD (  518): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-10 18:19:25.278+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 25204
07-10 18:19:25.298+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 18:19:25.303+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 18:19:25.303+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-10 18:19:25.303+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 18:19:25.308+0800 W/AUL_PAD (25114): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-10 18:19:25.308+0800 W/AUL_PAD (25114): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-10 18:19:25.308+0800 W/AUL_PAD (25114): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-10 18:19:25.308+0800 W/AUL_PAD (25114): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-10 18:19:25.388+0800 I/efl-extension(25114): efl_extension.c: eext_mod_init(40) > Init
07-10 18:19:25.393+0800 I/UXT     (25114): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:19:25.398+0800 W/AUL_PAD (25114): launchpad_loader.c: main(690) > [candidate] dlsym
07-10 18:19:25.398+0800 W/AUL_PAD (25114): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-10 18:19:25.398+0800 I/CAPI_APPFW_APPLICATION(25114): app_main.c: ui_app_main(704) > app_efl_main
07-10 18:19:25.403+0800 I/CAPI_APPFW_APPLICATION(25114): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 18:19:25.403+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(25114) type(uiapp) bg(0)
07-10 18:19:25.403+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (25114) was created
07-10 18:19:25.408+0800 W/AUL     (25204): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25114)
07-10 18:19:25.443+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [25114]
07-10 18:19:25.598+0800 I/efl-extension(25114): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 18:19:25.603+0800 I/efl-extension(25114): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 18:19:25.603+0800 I/efl-extension(25114): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 18:19:25.603+0800 I/efl-extension(25114): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 18:19:25.603+0800 I/efl-extension(25114): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445074a8, elm_image, _activated_obj : 0x0, activated : 1
07-10 18:19:25.608+0800 E/EFL     (25114): elementary<25114> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 18:19:25.613+0800 E/EFL     (25114): elementary<25114> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44507910) will be pushed
07-10 18:19:25.613+0800 I/efl-extension(25114): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x43c48a00]'s widget[0x44508da0] to layout widget[0x44507910]
07-10 18:19:25.618+0800 E/EFL     (25114): elementary<25114> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x43bb0b98 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:19:25.618+0800 E/EFL     (25114): elementary<25114> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x43bb0b98 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 18:19:25.618+0800 I/efl-extension(25114): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 18:19:25.908+0800 W/CRASH_MANAGER(25206): worker.c: worker_job(1205) > 112511473656e149968196
