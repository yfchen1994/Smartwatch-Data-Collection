S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 12644
Date: 2017-07-12 16:10:16+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 12644, uid 5000)

Register Information
r0   = 0xbee4e32c, r1   = 0x646d696d
r2   = 0x5a7779be, r3   = 0xbee4e43d
r4   = 0x403119b8, r5   = 0x403119b8
r6   = 0x4031116c, r7   = 0xbee4e130
r8   = 0x403119b8, r9   = 0x4157c548
r10  = 0x4031fb10, fp   = 0x00000000
ip   = 0x404f2cf4, sp   = 0xbee4df00
lr   = 0x413c0bb5, pc   = 0x404f2cfc
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:      5108 KB
Buffers:     29296 KB
Cached:     137140 KB
VmPeak:      84212 KB
VmSize:      82176 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24084 KB
VmRSS:       24084 KB
VmData:      18640 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12644 TID = 12644
12644 12776 

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
4151f000 4152a000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41535000 4153a000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41543000 415f3000 rw-p [heap]
41786000 41792000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
4179b000 417a0000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
418b0000 418d1000 r-xp /usr/lib/libefl-extension.so.0.1.0
418d9000 41903000 r-xp /usr/lib/libsensor.so.1.9.5
4190c000 41913000 r-xp /usr/lib/libctx-shared.so.0.8.3
4191b000 41920000 r-xp /usr/lib/libctx-client.so.0.8.3
41928000 4193a000 r-xp /usr/lib/libefl-assist.so.0.1.0
41942000 419fa000 r-xp /usr/lib/libcairo.so.2.11200.14
41a05000 41a0f000 r-xp /usr/lib/libsensord-shared.so
41a17000 41a26000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a2f000 41a45000 r-xp /usr/lib/libtts.so
41a4e000 41a71000 r-xp /usr/lib/libui-extension.so.0.1.0
41a7a000 41a85000 r-xp /usr/lib/libtbm.so.1.0.0
41a8d000 41a9b000 r-xp /usr/lib/libGLESv2.so.2.0
41aa4000 41aa5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41aae000 41ab4000 r-xp /usr/lib/libxcb-render.so.0.0.0
41abc000 41abf000 r-xp /usr/lib/libEGL.so.1.4
41ac7000 41aca000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41ad2000 41ad3000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41adc000 41c64000 r-xp /usr/lib/libicui18n.so.57.1
41c74000 41d7a000 r-xp /usr/lib/libicuuc.so.57.1
41d90000 41d98000 r-xp /usr/lib/libdrm.so.2.4.0
41da0000 41da2000 r-xp /usr/lib/libdri2.so.0.0.0
41daa000 41db0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41db8000 41dbd000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41dc5000 41dde000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4367f000 436a0000 r-xp /usr/lib/libexif.so.12.3.3
436b3000 436b5000 r-xp /usr/lib/libttrace.so.1.1
436bd000 436c2000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
436ca000 436d0000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
436d9000 436e1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
436e9000 4370b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43714000 4371b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43724000 43726000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4372e000 43735000 r-xp /usr/lib/libminizip.so.1.0.0
4373d000 4374a000 r-xp /usr/lib/libail.so.0.1.0
43753000 43759000 r-xp /usr/lib/libproc-stat.so.0.2.96
43761000 43762000 r-xp /usr/lib/libresponse.so.0.2.96
4376a000 4376f000 r-xp /usr/lib/libsystem.so.0.0.0
43779000 43843000 r-xp /usr/lib/libCOREGL.so.4.0
43be8000 43bf3000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43bfc000 43c01000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c09000 43c20000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c2d000 43c2f000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43c38000 444b6000 rw-p [stack:12776]
444b6000 444b7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444cd000 444ce000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444ec000 444f4000 r-xp /usr/lib/libfeedback.so.0.1.4
444f6000 444f7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44a4c000 44a4e000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44a56000 44a61000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44a69000 44a70000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44a78000 44a90000 r-xp /usr/lib/libmmfsound.so.0.1.0
44aa1000 44aa5000 r-xp /usr/lib/libmmfsession.so.0.0.0
44aae000 44ab9000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44ac6000 44aca000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44ad2000 44ae8000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44af0000 44b51000 r-xp /usr/lib/libasound.so.2.0.0
44b5b000 44b5e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44b66000 44b9e000 r-xp /usr/lib/libpulse.so.0.16.2
44b9f000 44ba2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44baa000 44bf2000 r-xp /usr/lib/libmdm.so.1.2.62
44bf3000 44bf6000 r-xp /usr/lib/libtinycompress.so.0.0.0
44bfe000 44c03000 r-xp /usr/lib/libjson.so.0.0.1
44c0b000 44c54000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44c5d000 44ca4000 r-xp /usr/lib/libsndfile.so.1.0.26
44cb0000 44cbf000 r-xp /usr/lib/libmdm-common.so.1.1.22
44cc8000 44cea000 r-xp /usr/lib/libvorbis.so.0.4.3
44cf2000 44cf6000 r-xp /usr/lib/libogg.so.0.7.1
bee2e000 bee4f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12644)
Call Stack Count: 1
 0: strcpy + 0x8 (0x404f2cfc) [/lib/libc.so.6] + 0x75cfc
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
() [0x41835d98 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 16:08:27.626+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x41835d98 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-12 16:08:27.656+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x41835d98 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-12 16:08:27.656+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x41835d98 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-12 16:08:27.736+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-12 16:08:27.736+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-12 16:08:27.736+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:08:27.736+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:08:27.741+0800 W/W_HOME  (  811): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-12 16:08:27.751+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[811] goes to (4)
07-12 16:08:27.751+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(811) status(bg) type(uiapp)
07-12 16:08:27.751+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 811)'s state(4)
07-12 16:08:27.761+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[12644] goes to (3)
07-12 16:08:27.766+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: PAUSE State: RUNNING
07-12 16:08:27.766+0800 I/CAPI_APPFW_APPLICATION(  811): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-12 16:08:27.766+0800 W/W_HOME  (  811): main.c: _appcore_pause_cb(487) > appcore pause
07-12 16:08:27.766+0800 W/W_HOME  (  811): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-12 16:08:27.766+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:08:27.766+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:08:27.766+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:08:27.766+0800 W/W_HOME  (  811): rotary.c: rotary_deattach(156) > rotary_deattach:0x474c2038
07-12 16:08:27.766+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-12 16:08:27.766+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x474c2038, elm_layout, func : 0x4005653d
07-12 16:08:27.766+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-12 16:08:27.766+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-12 16:08:27.766+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-12 16:08:27.766+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e39b0, elm_box, _activated_obj : 0x474c2038, activated : 1
07-12 16:08:27.766+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 16:08:27.766+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 16:08:27.766+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-12 16:08:27.776+0800 W/AUL_AMD (  524): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-12 16:08:27.776+0800 W/AUL_AMD (  524): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-12 16:08:27.776+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(12644) status(fg) type(uiapp)
07-12 16:08:27.811+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 16:08:27.811+0800 W/W_HOME  (  811): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-12 16:08:27.811+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 16:08:27.811+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 16:08:27.811+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 16:08:27.811+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-12 16:08:27.811+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-12 16:08:27.811+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 16:08:27.811+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 16:08:27.811+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 16:08:27.816+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 16:08:27.816+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 16:08:27.816+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 16:08:27.816+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-12 16:08:27.816+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-12 16:08:27.816+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 16:08:27.816+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 16:08:27.816+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-12 16:08:27.816+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-12 16:08:27.816+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 16:08:27.816+0800 E/CAPI_APPFW_APP_CONTROL( 1005): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-12 16:08:27.816+0800 W/MUSIC_CONTROL_SERVICE( 1005): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1005]   [com.samsung.w-home]register msg port [false][0m
07-12 16:08:27.816+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 16:08:27.821+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9272
07-12 16:08:27.826+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-12 16:08:27.826+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 16:08:27.831+0800 W/wnotib  (  811): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [1], notiboard card appending count [1].
07-12 16:08:27.836+0800 I/APP_CORE(12644): appcore-efl.c: __do_app(453) > [APP 12644] Event: RESUME State: RUNNING
07-12 16:08:27.841+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 16:08:27.856+0800 W/APPS    (  811): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-12 16:08:28.131+0800 E/AUL     (  524): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-12 16:08:28.326+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 16:08:28.706+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 16:08:28.716+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12644
07-12 16:08:28.726+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 16:08:28.751+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 16:08:28.761+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12644
07-12 16:08:28.761+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 16:08:29.021+0800 I/AUL_PAD (12740): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-12 16:08:32.661+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 16:08:32.836+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 16:08:44.671+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 16:08:57.646+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 16:08:59.486+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [4990][0;m
07-12 16:08:59.556+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
07-12 16:08:59.556+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
07-12 16:08:59.561+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : pedometer_inactive_period error
07-12 16:08:59.561+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
07-12 16:08:59.561+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
07-12 16:08:59.561+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_boolean(1173) > preference_get_boolean(1107) : inactive_test_mode_on error
07-12 16:08:59.561+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 16:08:59.596+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 16:09:00.336+0800 W/APPS    (  811): apps_main.c: _time_changed_cb(308) >  date : 12->12
07-12 16:09:22.351+0800 W/SHealthCommon( 1107): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499817600000.000000[0;m
07-12 16:09:22.406+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 16:09:22.436+0800 E/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-12 16:09:22.441+0800 W/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(379) > [1;40;33mOnNotWearingStart[0;m
07-12 16:09:22.526+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 16:09:22.536+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 16:09:22.556+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-12 16:09:22.556+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 16:09:22.566+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 16:09:22.571+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 16:09:22.581+0800 W/SHealthCommon( 1107): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499817600000.000000[0;m
07-12 16:09:22.606+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-12 16:09:22.616+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 16:09:22.631+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 16:09:22.636+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-12 16:09:22.641+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 16:09:22.656+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 16:10:00.406+0800 W/APPS    (  811): apps_main.c: _time_changed_cb(308) >  date : 12->12
07-12 16:10:02.966+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [705].
07-12 16:10:02.966+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(596960854)
07-12 16:10:03.016+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 16:10:03.021+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 16:10:03.021+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 09:59:08 (UTC).
07-12 16:10:03.021+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 16:10:03.021+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:10:03.051+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 16:10:03.051+0800 E/ALARM_MANAGER(  518): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[596960854] is removed.
07-12 16:10:03.051+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:10:03.061+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [705].
07-12 16:10:03.091+0800 I/AUL     (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
07-12 16:10:03.091+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 15
07-12 16:10:03.106+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
07-12 16:10:03.126+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
07-12 16:10:03.126+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499847007, Wed Jul 12 16:10:07 2017
07-12 16:10:03.126+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 643070289, next duetime: 1499847007
07-12 16:10:03.126+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(643070289)
07-12 16:10:03.126+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499853548), due_time(1499847007)
07-12 16:10:03.136+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 16:10:03.141+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 16:10:03.141+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 08:10:07 (UTC).
07-12 16:10:03.141+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 16:10:03.141+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:10:03.146+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 16:10:03.146+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:10:03.151+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [705].
07-12 16:10:03.151+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(643070289)
07-12 16:10:03.151+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1591639436) is OVER.
07-12 16:10:03.161+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 16:10:03.161+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 16:10:03.161+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 09:59:08 (UTC).
07-12 16:10:03.161+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 16:10:03.161+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:10:03.171+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 16:10:03.171+0800 E/ALARM_MANAGER(  518): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[643070289] is removed.
07-12 16:10:03.171+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:10:03.176+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [705].
07-12 16:10:03.191+0800 I/AUL     (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
07-12 16:10:03.191+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 15
07-12 16:10:03.206+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
07-12 16:10:03.216+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
07-12 16:10:03.216+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499890203, Thu Jul 13 04:10:03 2017
07-12 16:10:03.216+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 643070289, next duetime: 1499890203
07-12 16:10:03.216+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(643070289)
07-12 16:10:03.216+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499853548), due_time(1499890203)
07-12 16:10:03.226+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 16:10:03.226+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 16:10:03.226+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 09:59:08 (UTC).
07-12 16:10:03.226+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 16:10:03.226+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:10:03.231+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 16:10:03.231+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:10:07.141+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=20533572 button=1
07-12 16:10:07.141+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=20533572 button=1
07-12 16:10:07.141+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:07.141+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:07.141+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:07.151+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 16:10:07.466+0800 E/EFL     (12644): evas_main<12644> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-12 16:10:07.466+0800 E/EFL     (12644): evas_main<12644> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-12 16:10:07.466+0800 E/EFL     (12644): evas_main<12644> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-12 16:10:07.471+0800 E/EFL     (12644): evas_main<12644> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-12 16:10:07.471+0800 E/EFL     (12644): evas_main<12644> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-12 16:10:07.471+0800 E/EFL     (12644): evas_main<12644> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-12 16:10:07.471+0800 E/EFL     (12644): evas_main<12644> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-12 16:10:07.471+0800 E/EFL     (12644): evas_main<12644> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-12 16:10:07.471+0800 E/EFL     (12644): evas_main<12644> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-12 16:10:07.471+0800 E/EFL     (12644): evas_main<12644> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-12 16:10:07.471+0800 I/efl-extension(12644): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 16:10:07.471+0800 I/efl-extension(12644): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x448252f8, elm_image, _activated_obj : 0x445073b0, activated : 1
07-12 16:10:07.471+0800 I/efl-extension(12644): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 16:10:07.476+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 16:10:07.501+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x448258d8) will be pushed
07-12 16:10:07.501+0800 I/efl-extension(12644): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44d05a68]'s widget[0x4481f610] to layout widget[0x448258d8]
07-12 16:10:07.501+0800 I/efl-extension(12644): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 16:10:07.541+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:2796 _push_transition_cb() item(0x448258d8) will transition
07-12 16:10:07.961+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:1193 _on_item_push_finished() item(0x44507818) transition finished
07-12 16:10:07.961+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:1218 _on_item_show_finished() item(0x448258d8) transition finished
07-12 16:10:08.146+0800 E/EFL     (  397): ecore_x<397> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1600002 time=20533951
07-12 16:10:08.146+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=20533951
07-12 16:10:08.156+0800 E/EFL     (  397): ecore_x<397> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=20533951
07-12 16:10:09.531+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=20535964 button=1
07-12 16:10:09.676+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=20536110 button=1
07-12 16:10:10.076+0800 W/KEYROUTER(  397): e_mod_main.c: DeliverDeviceKeyEvents(3157) > Deliver KeyPress. value=2669, window=0x1600002
07-12 16:10:10.081+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=20536487
07-12 16:10:10.231+0800 W/KEYROUTER(  397): e_mod_main.c: DeliverDeviceKeyEvents(3168) > Deliver KeyRelease. value=2669, window=0x1600002
07-12 16:10:10.236+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=20536660
07-12 16:10:10.236+0800 E/efl-extension(12644): efl_extension_events.c: _eext_key_grab_rect_key_up_cb(240) > key up called
07-12 16:10:10.236+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:3136 elm_naviframe_item_pop() naviframe item pop
07-12 16:10:10.236+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:3149 elm_naviframe_item_pop() item(0x448258d8) will be popped.
07-12 16:10:10.236+0800 I/efl-extension(12644): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445073b0, elm_image, _activated_obj : 0x448252f8, activated : 1
07-12 16:10:10.236+0800 I/efl-extension(12644): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 16:10:10.326+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:2280 _pop_transition_cb() item(0x448258d8) will transition
07-12 16:10:10.771+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:1218 _on_item_show_finished() item(0x44507818) transition finished
07-12 16:10:10.771+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:1274 _on_item_pop_finished() item(0x448258d8) transition finished
07-12 16:10:10.776+0800 I/efl-extension(12644): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x448252f8, obj: 0x448252f8
07-12 16:10:10.776+0800 I/efl-extension(12644): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-12 16:10:10.776+0800 I/efl-extension(12644): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-12 16:10:10.776+0800 I/efl-extension(12644): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x44d05a68 is freed
07-12 16:10:10.811+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=20537229 button=1
07-12 16:10:10.811+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.811+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.811+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:10.816+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.816+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:10.826+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.826+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:10.826+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] add hold animator
07-12 16:10:10.831+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x41835d98 : elm_genlist] direction_x(1), direction_y(1)
07-12 16:10:10.831+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:3871 _elm_scroll_hold_animator() [0x41835d98 : elm_genlist] drag_child_locked_x(0)
07-12 16:10:10.831+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x41835d98 : elm_genlist] drag_child_locked_y(0)
07-12 16:10:10.831+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x41835d98 : elm_genlist] move content x(9), y(40)
07-12 16:10:10.881+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.881+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:10.886+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.886+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:10.886+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.886+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:10.886+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.886+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:10.886+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.886+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:10.891+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x41835d98 : elm_genlist] direction_x(1), direction_y(1)
07-12 16:10:10.891+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:3871 _elm_scroll_hold_animator() [0x41835d98 : elm_genlist] drag_child_locked_x(0)
07-12 16:10:10.891+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x41835d98 : elm_genlist] drag_child_locked_y(0)
07-12 16:10:10.891+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x41835d98 : elm_genlist] move content x(37), y(157)
07-12 16:10:10.946+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=20537360 button=1
07-12 16:10:10.951+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.951+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:10.951+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.951+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:10.951+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:10.951+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:11.421+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=20537856 button=1
07-12 16:10:11.421+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:11.431+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:11.431+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:11.441+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:11.441+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:11.451+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:11.451+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:11.476+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] mouse move
07-12 16:10:11.476+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x41835d98 : elm_genlist] hold(0), freeze(0)
07-12 16:10:11.486+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=20537921 button=1
07-12 16:10:11.556+0800 I/efl-extension(12644): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 16:10:11.556+0800 I/efl-extension(12644): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44825d10, elm_image, _activated_obj : 0x445073b0, activated : 1
07-12 16:10:11.561+0800 I/efl-extension(12644): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 16:10:11.576+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44823fb0 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-12 16:10:11.576+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44823fb0 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-12 16:10:11.591+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 16:10:11.601+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44dede80) will be pushed
07-12 16:10:11.601+0800 I/efl-extension(12644): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44d91938]'s widget[0x44d8b168] to layout widget[0x44dede80]
07-12 16:10:11.606+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44823fb0 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-12 16:10:11.606+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44823fb0 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-12 16:10:11.611+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44823fb0 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-12 16:10:11.611+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44823fb0 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-12 16:10:11.611+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44823fb0 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-12 16:10:11.611+0800 E/EFL     (12644): elementary<12644> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44823fb0 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-12 16:10:11.611+0800 I/efl-extension(12644): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 16:10:11.656+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:2796 _push_transition_cb() item(0x44dede80) will transition
07-12 16:10:12.076+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:1193 _on_item_push_finished() item(0x44507818) transition finished
07-12 16:10:12.081+0800 E/EFL     (12644): elementary<12644> elc_naviframe.c:1218 _on_item_show_finished() item(0x44dede80) transition finished
07-12 16:10:12.371+0800 W/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-12 16:10:12.376+0800 I/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-12 16:10:12.376+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 16:10:12.411+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 16:10:12.411+0800 I/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-12 16:10:12.466+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=20538899 button=1
07-12 16:10:12.501+0800 E/wnoti-service( 1046): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-12 16:10:12.501+0800 E/wnoti-service( 1046): wnoti-native-client.c: handle_cache_notification(737) > >>
07-12 16:10:12.506+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-12 16:10:12.516+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-12 16:10:12.516+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-12 16:10:12.516+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-12 16:10:12.516+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-12 16:10:12.516+0800 W/WECONN  (  506): <wc_manager_get_bearer_state:988> type : 1
07-12 16:10:12.551+0800 W/SHealthService( 1107): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-12 16:10:12.551+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 16:10:12.556+0800 E/ALARM_MANAGER(  506): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(12-7-2017, 16:10:18), repeat(0), interval(0), type(-1073741822)
07-12 16:10:12.561+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [506].
07-12 16:10:12.566+0800 E/EFL     (12644): ecore_x<12644> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=20539001 button=1
07-12 16:10:12.586+0800 E/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-12 16:10:12.586+0800 W/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(359) > [1;40;33mOnNotWearingStop[0;m
07-12 16:10:12.591+0800 I/AUL     (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 16:10:12.591+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 15
07-12 16:10:12.606+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 16:10:12.616+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 16:10:12.621+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499847018, Wed Jul 12 16:10:18 2017
07-12 16:10:12.621+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1137478448, next duetime: 1499847018
07-12 16:10:12.621+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1137478448)
07-12 16:10:12.621+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499853548), due_time(1499847018)
07-12 16:10:12.631+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 16:10:12.636+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 16:10:12.636+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 08:10:18 (UTC).
07-12 16:10:12.636+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 16:10:12.636+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:10:12.646+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 16:10:12.646+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:10:12.656+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:385> }
07-12 16:10:12.656+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:531> }
07-12 16:10:12.686+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 16:10:12.706+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 16:10:12.711+0800 W/SHealthCommon( 1107): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499817600000.000000[0;m
07-12 16:10:12.736+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-12 16:10:12.741+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-12 16:10:12.746+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 16:10:12.761+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 16:10:16.516+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 12644 pgid = 12644
07-12 16:10:16.516+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-12 16:10:16.526+0800 I/MALI    (  811): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-12 16:10:16.531+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[811] goes to (3)
07-12 16:10:16.531+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 811)'s state(3)
07-12 16:10:16.536+0800 W/AUL_AMD (  524): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-12 16:10:16.536+0800 W/AUL_AMD (  524): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-12 16:10:16.536+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(811) status(fg) type(uiapp)
07-12 16:10:16.656+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-12 16:10:16.666+0800 I/AUL_AMD (  524): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12644
07-12 16:10:16.666+0800 W/AUL     (  524): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12644)
07-12 16:10:16.691+0800 W/PROCESSMGR(  397): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
07-12 16:10:16.756+0800 W/WATCH_CORE(  901): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
07-12 16:10:16.756+0800 I/WATCH_CORE(  901): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
07-12 16:10:16.756+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 16:10:16.756+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 16:10:16.756+0800 I/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-12 16:10:16.766+0800 W/CRASH_MANAGER(12799): worker.c: worker_job(1205) > 111264473656e149984701
