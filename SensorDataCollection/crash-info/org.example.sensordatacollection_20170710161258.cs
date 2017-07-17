S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 9161
Date: 2017-07-10 16:12:58+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x414d0fbc
r2   = 0x414d0e40, r3   = 0x00000001
r4   = 0x00000000, r5   = 0x414c0acb
r6   = 0x414c0a97, r7   = 0xbefe4208
r8   = 0x414728cb, r9   = 0x000023c9
r10  = 0x4004e7e8, fp   = 0x00000000
ip   = 0x404d9b50, sp   = 0xbefe3f38
lr   = 0x414c0903, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:      4076 KB
Buffers:     15596 KB
Cached:     135400 KB
VmPeak:      72896 KB
VmSize:      72896 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14848 KB
VmRSS:       14848 KB
VmData:      13468 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22904 KB
VmPTE:          44 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9161 TID = 9161
9161 9174 

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
418c8000 418e9000 r-xp /usr/lib/libefl-extension.so.0.1.0
418f1000 41903000 r-xp /usr/lib/libefl-assist.so.0.1.0
4190b000 419c3000 r-xp /usr/lib/libcairo.so.2.11200.14
419ce000 419e4000 r-xp /usr/lib/libtts.so
419ed000 41a10000 r-xp /usr/lib/libui-extension.so.0.1.0
41a19000 41a24000 r-xp /usr/lib/libtbm.so.1.0.0
41a2c000 41a3a000 r-xp /usr/lib/libGLESv2.so.2.0
41a43000 41a44000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a4d000 41a53000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a5b000 41a5e000 r-xp /usr/lib/libEGL.so.1.4
41a66000 41a6b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a73000 41a76000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a7e000 41a7f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a88000 41c10000 r-xp /usr/lib/libicui18n.so.57.1
41c20000 41d26000 r-xp /usr/lib/libicuuc.so.57.1
41d3c000 41d44000 r-xp /usr/lib/libdrm.so.2.4.0
41d4c000 41d4e000 r-xp /usr/lib/libdri2.so.0.0.0
41d56000 41d5c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d64000 41d69000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d71000 41d8a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4362b000 4364c000 r-xp /usr/lib/libexif.so.12.3.3
4365f000 43661000 r-xp /usr/lib/libttrace.so.1.1
43669000 4366e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43676000 4367c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43685000 4368d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43695000 436b7000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
436c0000 436c7000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436d0000 436d2000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436da000 436e1000 r-xp /usr/lib/libminizip.so.1.0.0
436e9000 436f6000 r-xp /usr/lib/libail.so.0.1.0
436ff000 43705000 r-xp /usr/lib/libproc-stat.so.0.2.96
4370d000 4370e000 r-xp /usr/lib/libresponse.so.0.2.96
43716000 4371b000 r-xp /usr/lib/libsystem.so.0.0.0
43725000 437ef000 r-xp /usr/lib/libCOREGL.so.4.0
43b94000 43b9f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ba8000 43bad000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43bb5000 43bcc000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43bd9000 43bdb000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43be4000 444e3000 rw-p [stack:9174]
444e3000 444e4000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
befc4000 befe5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9161)
Call Stack Count: 11
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: start_data_collection + 0xda (0x414c0903) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2903
 2: create_base_gui + 0x152 (0x414bfcc7) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1cc7
 3: app_create + 0x12 (0x414bfabf) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1abf
 4: (0x414919c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 5: appcore_efl_main + 0x246 (0x40044a5b) [/usr/lib/libappcore-efl.so.1] + 0x3a5b
 6: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: main + 0x116 (0x414bfa47) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a47
 8: main + 0x122 (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
 9: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
10: create_list_view + 0xf7 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
> select index:1
07-10 16:12:54.420+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(267), py(0)
07-10 16:12:54.420+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] time(0.741681)
07-10 16:12:54.420+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(267), py(0)
07-10 16:12:54.430+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] time(0.781883)
07-10 16:12:54.430+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
07-10 16:12:54.430+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
07-10 16:12:54.430+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(579) > 0
07-10 16:12:54.430+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(589) > select index:1
07-10 16:12:54.435+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(281), py(0)
07-10 16:12:54.435+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] time(0.781883)
07-10 16:12:54.435+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(281), py(0)
07-10 16:12:54.455+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] time(0.851492)
07-10 16:12:54.455+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
07-10 16:12:54.455+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
07-10 16:12:54.455+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(579) > 0
07-10 16:12:54.455+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(589) > select index:1
07-10 16:12:54.455+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(306), py(0)
07-10 16:12:54.455+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] time(0.851492)
07-10 16:12:54.455+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(306), py(0)
07-10 16:12:54.465+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] time(0.881175)
07-10 16:12:54.465+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
07-10 16:12:54.465+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
07-10 16:12:54.465+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(579) > 0
07-10 16:12:54.465+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(589) > select index:1
07-10 16:12:54.465+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(317), py(0)
07-10 16:12:54.465+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] time(0.881175)
07-10 16:12:54.465+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(317), py(0)
07-10 16:12:54.480+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] time(0.922990)
07-10 16:12:54.485+0800 W/W_HOME  (  824): event_manager.c: _clock_view_visible_cb(637) > state: 0 -> 1
07-10 16:12:54.485+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-10 16:12:54.485+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-10 16:12:54.485+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
07-10 16:12:54.485+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
07-10 16:12:54.485+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(579) > 0
07-10 16:12:54.485+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(589) > select index:1
07-10 16:12:54.485+0800 W/W_INDICATOR(  760): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 1
07-10 16:12:54.485+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
07-10 16:12:54.485+0800 W/W_INDICATOR(  760): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
07-10 16:12:54.485+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(332), py(0)
07-10 16:12:54.485+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] time(0.922990)
07-10 16:12:54.485+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(332), py(0)
07-10 16:12:54.490+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(80), length(2)
07-10 16:12:54.490+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 80%
07-10 16:12:54.490+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 80, isCharging: 0
07-10 16:12:54.490+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_80
07-10 16:12:54.490+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
07-10 16:12:54.500+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] time(0.951061)
07-10 16:12:54.500+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
07-10 16:12:54.500+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
07-10 16:12:54.500+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(579) > 0
07-10 16:12:54.500+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(589) > select index:1
07-10 16:12:54.500+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(342), py(0)
07-10 16:12:54.500+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] time(0.951061)
07-10 16:12:54.500+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(342), py(0)
07-10 16:12:54.515+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] time(0.974328)
07-10 16:12:54.515+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
07-10 16:12:54.515+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
07-10 16:12:54.515+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(579) > 0
07-10 16:12:54.515+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(589) > select index:1
07-10 16:12:54.515+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(350), py(0)
07-10 16:12:54.515+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] time(0.974328)
07-10 16:12:54.515+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(350), py(0)
07-10 16:12:54.530+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] time(0.990108)
07-10 16:12:54.530+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
07-10 16:12:54.530+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
07-10 16:12:54.530+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(579) > 0
07-10 16:12:54.530+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(589) > select index:1
07-10 16:12:54.530+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(356), py(0)
07-10 16:12:54.530+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] time(0.990108)
07-10 16:12:54.530+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(356), py(0)
07-10 16:12:54.545+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] time(0.998532)
07-10 16:12:54.550+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
07-10 16:12:54.550+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
07-10 16:12:54.550+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(579) > 0
07-10 16:12:54.550+0800 W/W_HOME  (  824): noti_broker.c: _handler_indicator_select(589) > select index:1
07-10 16:12:54.550+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(359), py(0)
07-10 16:12:54.550+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] time(0.998532)
07-10 16:12:54.550+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_RENEW : px(359), py(0)
07-10 16:12:54.565+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] time(0.999463)
07-10 16:12:54.565+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
07-10 16:12:54.565+0800 I/ELM_RPANEL(  824): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
07-10 16:12:54.565+0800 W/ELM_RPANEL(  824): elm-rpanel.c: _elm_rpanel_smart_move(1802) > Move out of notiboard, sd->scroll_x [360], panel count [0], page_rect_w [360], scroller_x [360]
07-10 16:12:54.565+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_CANCEL : px(360), py(0)
07-10 16:12:54.565+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] time(0.999463)
07-10 16:12:54.565+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] animation stop!!
07-10 16:12:54.570+0800 I/wnotib  (  824): w-notification-board-common.c: wnotib_common_set_panel_displayed_state(4968) > Set is_notiboard_displayed to 0.
07-10 16:12:54.570+0800 I/wnotib  (  824): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(59) > type: 8
07-10 16:12:54.570+0800 I/wnotib  (  824): w-notification-board-empty-panel.c: _wnb_ep_set_texts(346) > is_connected_vendor_LO: 0, is_standalone_mode: 0
07-10 16:12:54.570+0800 E/TIZEN_N_SYSTEM_SETTINGS(  824): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
07-10 16:12:54.570+0800 E/TIZEN_N_SYSTEM_SETTINGS(  824): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
07-10 16:12:54.570+0800 E/TIZEN_N_SYSTEM_SETTINGS(  824): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
07-10 16:12:54.570+0800 E/TIZEN_N_SYSTEM_SETTINGS(  824): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
07-10 16:12:54.595+0800 W/wnotib  (  824): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [360][0][360][360]
07-10 16:12:54.595+0800 W/wnotib  (  824): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 1.
07-10 16:12:54.595+0800 W/W_HOME  (  824): home_navigation.c: _anim_stop_cb(1316) > anim stop
07-10 16:12:54.595+0800 W/W_HOME  (  824): home_navigation.c: _nav_finish_timer_del(822) > delete timer
07-10 16:12:54.595+0800 W/W_HOME  (  824): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
07-10 16:12:54.595+0800 W/W_HOME  (  824): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
07-10 16:12:54.595+0800 I/efl-extension(  824): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x460c6b40 : elm_scroller] detent_count(0)
07-10 16:12:54.595+0800 I/efl-extension(  824): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x460c6b40 : elm_scroller] pagenumber_v(0), pagenumber_h(1)
07-10 16:12:54.595+0800 I/efl-extension(  824): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x460c6b40 : elm_scroller] CurrentPage(1)
07-10 16:12:54.595+0800 E/EFL     (  824): elementary<824> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x460c6b40 : elm_scroller] ECORE_CALLBACK_CANCEL : px(360), py(0)
07-10 16:12:54.595+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:54.595+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:54.700+0800 E/W_HOME  (  824): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
07-10 16:12:54.715+0800 W/W_HOME  (  824): event_manager.c: _home_scroll_cb(585) > scroll,will,done
07-10 16:12:54.715+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-10 16:12:54.715+0800 W/W_HOME  (  824): event_manager.c: _home_scroll_cb(585) > scroll,done
07-10 16:12:54.715+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-10 16:12:54.795+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:54.795+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:54.870+0800 W/KEYROUTER(  469): e_mod_main.c: DeliverDeviceKeyEvents(3237) > Deliver KeyPress to focus window. value=1997, window=0x2e00003
07-10 16:12:54.870+0800 W/KEYROUTER(  469): e_mod_main.c: DeliverDeviceKeyEvents(3248) > Deliver KeyPress as shared grab. value=1997, window=0x2200002
07-10 16:12:54.870+0800 W/STARTER (  759): hw_key.c: _key_press_cb(1443) > [_key_press_cb:1443] POWER Key is pressed
07-10 16:12:54.870+0800 W/STARTER (  759): hw_key.c: _key_press_cb(1446) > [_key_press_cb:1446] LCD state : 1
07-10 16:12:54.870+0800 W/STARTER (  759): hw_key.c: _key_press_cb(1453) > [_key_press_cb:1453] PM state : 1
07-10 16:12:54.870+0800 E/STARTER (  759): hw_key.c: _key_press_cb(1459) > [_key_press_cb:1459] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
07-10 16:12:54.870+0800 W/STARTER (  759): hw_key.c: _key_press_cb(1462) > [_key_press_cb:1462] Simple Clock state : 0
07-10 16:12:54.870+0800 W/STARTER (  759): hw_key.c: _key_press_cb(1467) > [_key_press_cb:1467] powerkey count : 1
07-10 16:12:54.870+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=5991835
07-10 16:12:54.870+0800 W/W_HOME  (  824): main.c: _direct_home_key_cb(1444) > was_win_on_top:1
07-10 16:12:54.995+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:54.995+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:55.025+0800 W/KEYROUTER(  469): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x2200002
07-10 16:12:55.025+0800 W/KEYROUTER(  469): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x2e00003
07-10 16:12:55.025+0800 W/STARTER (  759): hw_key.c: _key_release_cb(1340) > [_key_release_cb:1340] POWER Key is released
07-10 16:12:55.025+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=5991990
07-10 16:12:55.095+0800 W/W_HOME  (  824): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
07-10 16:12:55.195+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:55.195+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:55.270+0800 W/AUL_AMD (  518): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-10 16:12:55.270+0800 W/AUL_AMD (  518): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
07-10 16:12:55.275+0800 W/STARTER (  759): hw_key.c: _powerkey_timer_cb(922) > [_powerkey_timer_cb:922] _powerkey_timer_cb, powerkey count[1]
07-10 16:12:55.280+0800 W/STARTER (  759): hw_key.c: _powerkey_timer_cb(1132) > [_powerkey_timer_cb:1132] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
07-10 16:12:55.280+0800 E/STARTER (  759): dbus-util.c: dbus_request_cpu_boost(292) > [dbus_request_cpu_boost:292] failed to _invoke_dbus_method_sync
07-10 16:12:55.280+0800 W/AUL     (  759): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
07-10 16:12:55.280+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 16:12:55.280+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 759
07-10 16:12:55.285+0800 W/AUL     (  518): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(824) type(uiapp) bg(0)
07-10 16:12:55.285+0800 W/AUL_AMD (  518): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 824
07-10 16:12:55.290+0800 I/APP_CORE(  824): appcore-efl.c: __do_app(453) > [APP 824] Event: RESET State: RUNNING
07-10 16:12:55.290+0800 I/CAPI_APPFW_APPLICATION(  824): app_main.c: app_appcore_reset(245) > app_appcore_reset
07-10 16:12:55.290+0800 W/CAPI_APPFW_APP_CONTROL(  824): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
07-10 16:12:55.290+0800 E/W_HOME  (  824): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
07-10 16:12:55.290+0800 W/W_HOME  (  824): main.c: _app_control_progress(1568) > Service value : powerkey
07-10 16:12:55.290+0800 W/wnotib  (  824): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x40001
07-10 16:12:55.290+0800 E/wnotib  (  824): w-notification-board-action.c: wnb_action_is_popup_shown(4742) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-10 16:12:55.290+0800 E/wnotib  (  824): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-10 16:12:55.290+0800 W/wnotib  (  824): w-notification-board-broker-main.c: wnotib_main_dismiss_confirmation_popup(1427) > 
07-10 16:12:55.290+0800 W/W_HOME  (  824): noti_broker.c: _noti_broker_home_cb(779) > continue the home key execution
07-10 16:12:55.290+0800 E/W_HOME  (  824): cs_broker.c: _cs_broker_home_cb(274) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
07-10 16:12:55.290+0800 W/W_HOME  (  824): main.c: _home_key_cb(1466) > Home Key operation tutorial:0 window:1 clock:1 apps:0 is_app_resumed:1
07-10 16:12:55.290+0800 W/W_HOME  (  824): move.c: move_move_to_apps(216) > move to apps
07-10 16:12:55.290+0800 W/W_HOME  (  824): rotary.c: rotary_attach(138) > rotary_attach:0x47dbbcc8
07-10 16:12:55.290+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47dbbcc8, elm_layout, _activated_obj : 0x460e3b10, activated : 1
07-10 16:12:55.290+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-10 16:12:55.290+0800 W/W_HOME  (  824): event_manager.c: _move_module_anim_start_cb(666) > state: 0 -> 1
07-10 16:12:55.290+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-10 16:12:55.290+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-10 16:12:55.290+0800 W/APPS    (  824): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-10 16:12:55.290+0800 W/W_INDICATOR(  760): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-10 16:12:55.290+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-10 16:12:55.295+0800 W/AUL_AMD (  518): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(824), cmd(0)
07-10 16:12:55.295+0800 E/AUL     (  518): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-10 16:12:55.295+0800 W/AUL     (  759): launch.c: app_request_to_launchpad(298) > request cmd(0) result(824)
07-10 16:12:55.295+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [824]
07-10 16:12:55.300+0800 I/APP_CORE(  824): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
07-10 16:12:55.305+0800 W/W_HOME  (  824): event_manager.c: _apptray_visibility_cb(604) > apps,show,start
07-10 16:12:55.305+0800 W/W_HOME  (  824): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 0
07-10 16:12:55.305+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-10 16:12:55.305+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-10 16:12:55.305+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-10 16:12:55.305+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-10 16:12:55.305+0800 W/W_HOME  (  824): noti_broker.c: _apptray_visibility_cb(786) > apps,show,start
07-10 16:12:55.305+0800 W/W_HOME  (  824): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80002
07-10 16:12:55.305+0800 W/wnotib  (  824): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80002
07-10 16:12:55.305+0800 I/wnotib  (  824): w-notification-board-broker-main.c: _wnotib_view_event_handler(1418) > Unhandled type: 0x80002
07-10 16:12:55.310+0800 E/AUL     (  759): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-10 16:12:55.310+0800 W/W_INDICATOR(  760): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-10 16:12:55.310+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-10 16:12:55.395+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 16:12:55.395+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 16:12:55.570+0800 W/W_HOME  (  824): event_manager.c: _move_module_anim_end_cb(680) > state: 1 -> 0
07-10 16:12:55.570+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-10 16:12:55.570+0800 W/W_HOME  (  824): rotary.c: rotary_deattach(156) > rotary_deattach:0x47dbbcc8
07-10 16:12:55.570+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-10 16:12:55.570+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47dbbcc8, elm_layout, func : 0x4005653d
07-10 16:12:55.570+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-10 16:12:55.570+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-10 16:12:55.570+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-10 16:12:55.570+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e3b10, elm_box, _activated_obj : 0x47dbbcc8, activated : 1
07-10 16:12:55.570+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-10 16:12:55.570+0800 E/wnotib  (  824): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-10 16:12:55.570+0800 I/wnotib  (  824): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-10 16:12:55.570+0800 W/W_HOME  (  824): event_manager.c: _apptray_visibility_cb(604) > apps,show
07-10 16:12:55.575+0800 W/W_HOME  (  824): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 1
07-10 16:12:55.575+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 16:12:55.575+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 16:12:55.575+0800 W/W_HOME  (  824): main.c: home_pause(546) > clock/widget paused
07-10 16:12:55.575+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 16:12:55.575+0800 W/APPS    (  824): apps_main.c: _time_changed_cb(308) >  date : 10->10
07-10 16:12:55.575+0800 W/APPS    (  824): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-10 16:12:55.575+0800 W/W_INDICATOR(  760): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-10 16:12:55.575+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-10 16:12:55.575+0800 W/W_HOME  (  824): rotary.c: rotary_attach(138) > rotary_attach:0x473287a0
07-10 16:12:55.575+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x473287a0, elm_layout, _activated_obj : 0x460e3b10, activated : 1
07-10 16:12:55.575+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-10 16:12:55.575+0800 W/W_HOME  (  824): win.c: win_back_gesture_disable_set(170) > disable back gesture
07-10 16:12:55.575+0800 W/W_HOME  (  824): win.c: win_back_gesture_disable_set(170) > disable back gesture
07-10 16:12:55.575+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 16:12:55.575+0800 W/W_HOME  (  824): noti_broker.c: _apptray_visibility_cb(786) > apps,show
07-10 16:12:55.575+0800 W/W_HOME  (  824): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80000
07-10 16:12:55.575+0800 W/wnotib  (  824): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80000
07-10 16:12:55.575+0800 I/wnotib  (  824): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 1
07-10 16:12:55.575+0800 W/wnotib  (  824): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-10 16:12:55.575+0800 E/APPS    (  824): apps_main.c: apps_main_resume(1003) >  resumed already
07-10 16:12:55.590+0800 W/WATCH_CORE(  904): appcore-watch.c: __widget_pause(1113) > widget_pause
07-10 16:12:55.590+0800 W/AUL     (  904): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(904) status(bg) type(watchapp)
07-10 16:12:55.595+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppPause(589) > 
07-10 16:12:56.300+0800 W/AUL_AMD (  518): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-10 16:12:56.300+0800 W/AUL_AMD (  518): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
07-10 16:12:56.445+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5993405 button=1
07-10 16:12:56.445+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [284, 123]
07-10 16:12:56.445+0800 E/W_HOME  (  824): util.c: util_is_rdu_retailmode(1372) > Cannot get the vconf for retailmode
07-10 16:12:56.510+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5993475 button=1
07-10 16:12:56.510+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [284, 123]->[277, 127]
07-10 16:12:56.510+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[32], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 16:12:56.510+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,32]
07-10 16:12:56.510+0800 E/APPS    (  824): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
07-10 16:12:56.510+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(487) >  item(sensordatacollection) launched, open(0), tts(0)
07-10 16:12:56.520+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 16:12:56.520+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 16:12:56.520+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 824
07-10 16:12:56.520+0800 I/AUL_AMD (  518): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-10 16:12:56.530+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 16:12:56.530+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-10 16:12:56.530+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 16:12:56.535+0800 W/AUL_PAD ( 9098): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-10 16:12:56.535+0800 W/AUL_PAD ( 9098): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-10 16:12:56.535+0800 W/AUL_PAD ( 9098): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-10 16:12:56.535+0800 W/AUL_PAD ( 9098): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-10 16:12:56.540+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 16:12:56.580+0800 I/efl-extension( 9098): efl_extension.c: eext_mod_init(40) > Init
07-10 16:12:56.585+0800 I/UXT     ( 9098): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 16:12:56.585+0800 W/AUL_PAD ( 9098): launchpad_loader.c: main(690) > [candidate] dlsym
07-10 16:12:56.585+0800 W/AUL_PAD ( 9098): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-10 16:12:56.585+0800 I/CAPI_APPFW_APPLICATION( 9098): app_main.c: ui_app_main(704) > app_efl_main
07-10 16:12:56.590+0800 I/CAPI_APPFW_APPLICATION( 9098): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 16:12:56.635+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(9098) type(uiapp) bg(0)
07-10 16:12:56.635+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9098)
07-10 16:12:56.635+0800 W/W_HOME  (  824): util.c: apps_util_launch_main_operation(643) > Launch app:[sensordatacollection] ret:[0]
07-10 16:12:56.635+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (9098) was created
07-10 16:12:56.635+0800 E/AUL     (  518): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-10 16:12:56.645+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9098]
07-10 16:12:56.755+0800 I/efl-extension( 9098): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 16:12:56.755+0800 I/efl-extension( 9098): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 16:12:56.755+0800 I/efl-extension( 9098): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 16:12:56.755+0800 I/efl-extension( 9098): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 16:12:56.755+0800 I/efl-extension( 9098): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x444073f8, elm_image, _activated_obj : 0x0, activated : 1
07-10 16:12:56.755+0800 E/EFL     ( 9098): elementary<9098> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 16:12:56.760+0800 E/EFL     ( 9098): elementary<9098> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44407860) will be pushed
07-10 16:12:56.760+0800 I/efl-extension( 9098): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x417f6360]'s widget[0x44408cf0] to layout widget[0x44407860]
07-10 16:12:56.765+0800 E/EFL     ( 9098): elementary<9098> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e7fa8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 16:12:56.765+0800 E/EFL     ( 9098): elementary<9098> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e7fa8 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 16:12:56.765+0800 I/efl-extension( 9098): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 16:12:56.870+0800 W/CRASH_MANAGER( 9086): worker.c: worker_job(1205) > 110909873656e1499674376
07-10 16:12:57.310+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5994273 button=1
07-10 16:12:57.370+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5994336 button=1
07-10 16:12:57.640+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5994600 button=1
07-10 16:12:57.725+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5994691 button=1
07-10 16:12:57.770+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 9098 pgid = 9098
07-10 16:12:57.770+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-10 16:12:57.780+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
07-10 16:12:57.780+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
07-10 16:12:57.780+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(9098), proc(0)
07-10 16:12:57.780+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
07-10 16:12:57.785+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
07-10 16:12:57.785+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
07-10 16:12:57.785+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(9098), proc(0)
07-10 16:12:57.785+0800 E/AUL     ( 1110): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
07-10 16:12:57.785+0800 E/CAPI_APPFW_APP_MANAGER( 1110): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
07-10 16:12:57.785+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
07-10 16:12:57.785+0800 E/AUL     ( 5906): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
07-10 16:12:57.785+0800 E/CAPI_APPFW_APP_MANAGER( 5906): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
07-10 16:12:57.790+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
07-10 16:12:57.790+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
07-10 16:12:57.790+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(9098), proc(0)
07-10 16:12:57.790+0800 E/AUL     (  950): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
07-10 16:12:57.790+0800 E/CAPI_APPFW_APP_MANAGER(  950): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
07-10 16:12:57.795+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
07-10 16:12:57.865+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 16:12:57.870+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9098
07-10 16:12:57.870+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9098)
07-10 16:12:58.045+0800 I/AUL_PAD ( 9161): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 16:12:58.210+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5995175 button=1
07-10 16:12:58.210+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5995175 button=1
07-10 16:12:58.210+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [301, 127]
07-10 16:12:58.215+0800 E/W_HOME  (  824): util.c: util_is_rdu_retailmode(1372) > Cannot get the vconf for retailmode
07-10 16:12:58.215+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [301, 127]->[294, 135]
07-10 16:12:58.215+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[32], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 16:12:58.215+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,32]
07-10 16:12:58.215+0800 E/APPS    (  824): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
07-10 16:12:58.215+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(487) >  item(sensordatacollection) launched, open(0), tts(0)
07-10 16:12:58.215+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 16:12:58.215+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 16:12:58.220+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 824
07-10 16:12:58.220+0800 I/AUL_AMD (  518): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-10 16:12:58.230+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 16:12:58.230+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-10 16:12:58.230+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 16:12:58.230+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 16:12:58.230+0800 W/AUL_PAD ( 9161): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-10 16:12:58.230+0800 W/AUL_PAD ( 9161): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-10 16:12:58.230+0800 W/AUL_PAD ( 9161): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-10 16:12:58.230+0800 W/AUL_PAD ( 9161): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-10 16:12:58.275+0800 I/efl-extension( 9161): efl_extension.c: eext_mod_init(40) > Init
07-10 16:12:58.280+0800 I/UXT     ( 9161): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 16:12:58.280+0800 W/AUL_PAD ( 9161): launchpad_loader.c: main(690) > [candidate] dlsym
07-10 16:12:58.280+0800 W/AUL_PAD ( 9161): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-10 16:12:58.280+0800 I/CAPI_APPFW_APPLICATION( 9161): app_main.c: ui_app_main(704) > app_efl_main
07-10 16:12:58.285+0800 I/CAPI_APPFW_APPLICATION( 9161): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 16:12:58.330+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(9161) type(uiapp) bg(0)
07-10 16:12:58.330+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (9161) was created
07-10 16:12:58.330+0800 E/AUL     (  518): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-10 16:12:58.330+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9161]
07-10 16:12:58.330+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9161)
07-10 16:12:58.330+0800 W/W_HOME  (  824): util.c: apps_util_launch_main_operation(643) > Launch app:[sensordatacollection] ret:[0]
07-10 16:12:58.465+0800 I/efl-extension( 9161): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 16:12:58.465+0800 I/efl-extension( 9161): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 16:12:58.465+0800 I/efl-extension( 9161): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 16:12:58.465+0800 I/efl-extension( 9161): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 16:12:58.465+0800 I/efl-extension( 9161): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x417f8ed0, elm_image, _activated_obj : 0x0, activated : 1
07-10 16:12:58.465+0800 E/EFL     ( 9161): elementary<9161> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 16:12:58.470+0800 E/EFL     ( 9161): elementary<9161> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x417f9338) will be pushed
07-10 16:12:58.470+0800 I/efl-extension( 9161): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x443ef2d8]'s widget[0x417fa7c8] to layout widget[0x417f9338]
07-10 16:12:58.475+0800 E/EFL     ( 9161): elementary<9161> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e7fa8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 16:12:58.475+0800 E/EFL     ( 9161): elementary<9161> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e7fa8 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 16:12:58.475+0800 I/efl-extension( 9161): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 16:12:58.545+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5995509 button=1
07-10 16:12:58.575+0800 W/CRASH_MANAGER( 9086): worker.c: worker_job(1205) > 110916173656e149967437
