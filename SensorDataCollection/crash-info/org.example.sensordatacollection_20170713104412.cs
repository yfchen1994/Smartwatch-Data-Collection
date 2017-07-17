S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 18414
Date: 2017-07-13 10:44:12+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18414, uid 5000)

Register Information
r0   = 0xbef9a32d, r1   = 0x00000000
r2   = 0x31fc7d00, r3   = 0x00000000
r4   = 0x44d75d00, r5   = 0x44d56430
r6   = 0x44d50450, r7   = 0xbef9a010
r8   = 0x00000000, r9   = 0x44d77288
r10  = 0x44d899a0, fp   = 0x00000001
ip   = 0x413d1dec, sp   = 0xbef99fe0
lr   = 0x413c0135, pc   = 0x404f2cb8
cpsr = 0x80000010

Memory Information
MemTotal:   491132 KB
MemFree:     30424 KB
Buffers:     11420 KB
Cached:     138008 KB
VmPeak:      96992 KB
VmSize:      95972 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23772 KB
VmRSS:       23772 KB
VmData:      18896 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25500 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18414 TID = 18414
18414 18496 

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
41427000 41431000 r-xp /lib/libnss_files-2.13.so
4143a000 41445000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41450000 41455000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41464000 41485000 rw-p [heap]
41485000 41554000 r-xp /usr/lib/libscim-1.0.so.8.2.3
417fd000 41809000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
41812000 41833000 r-xp /usr/lib/libefl-extension.so.0.1.0
4183b000 41840000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41848000 41872000 r-xp /usr/lib/libsensor.so.1.9.5
4187b000 41882000 r-xp /usr/lib/libctx-shared.so.0.8.3
4188a000 4188f000 r-xp /usr/lib/libctx-client.so.0.8.3
41897000 418a9000 r-xp /usr/lib/libefl-assist.so.0.1.0
418b1000 41969000 r-xp /usr/lib/libcairo.so.2.11200.14
41974000 4197e000 r-xp /usr/lib/libsensord-shared.so
41986000 41995000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
4199e000 419b4000 r-xp /usr/lib/libtts.so
419bd000 419e0000 r-xp /usr/lib/libui-extension.so.0.1.0
419e9000 419f4000 r-xp /usr/lib/libtbm.so.1.0.0
419fc000 41a0a000 r-xp /usr/lib/libGLESv2.so.2.0
41a13000 41a14000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a1d000 41a23000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a2b000 41a2e000 r-xp /usr/lib/libEGL.so.1.4
41a36000 41a39000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a41000 41a42000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a4b000 41bd3000 r-xp /usr/lib/libicui18n.so.57.1
41be3000 41ce9000 r-xp /usr/lib/libicuuc.so.57.1
41cff000 41d07000 r-xp /usr/lib/libdrm.so.2.4.0
41d0f000 41d11000 r-xp /usr/lib/libdri2.so.0.0.0
41d19000 41d1f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d27000 41d2c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d34000 41d4d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
435ee000 4360f000 r-xp /usr/lib/libexif.so.12.3.3
43622000 43624000 r-xp /usr/lib/libttrace.so.1.1
4362c000 43631000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43639000 4363f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43648000 43650000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43658000 4367a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43683000 4368a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43693000 43695000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4369d000 436a4000 r-xp /usr/lib/libminizip.so.1.0.0
436ac000 436b9000 r-xp /usr/lib/libail.so.0.1.0
436c2000 436c8000 r-xp /usr/lib/libproc-stat.so.0.2.96
436d0000 436d1000 r-xp /usr/lib/libresponse.so.0.2.96
436d9000 436de000 r-xp /usr/lib/libsystem.so.0.0.0
437e8000 438b2000 r-xp /usr/lib/libCOREGL.so.4.0
43c57000 43c62000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c6b000 43c70000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c78000 43c8f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c9c000 43c9e000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43ca7000 444a6000 rw-p [stack:18496]
444a6000 444a7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44a4c000 44a4d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44a55000 44a5a000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
44a6b000 44a73000 r-xp /usr/lib/libfeedback.so.0.1.4
44a75000 44a76000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44a7e000 44a80000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44a88000 44a93000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44a9b000 44aa2000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44aaa000 44ac2000 r-xp /usr/lib/libmmfsound.so.0.1.0
44ad3000 44ad7000 r-xp /usr/lib/libmmfsession.so.0.0.0
44ae0000 44aeb000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44af8000 44afc000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44b04000 44b1a000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44b22000 44b83000 r-xp /usr/lib/libasound.so.2.0.0
44b8d000 44b90000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44b98000 44bd0000 r-xp /usr/lib/libpulse.so.0.16.2
44bd1000 44bd4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44bdc000 44c24000 r-xp /usr/lib/libmdm.so.1.2.62
44c25000 44c28000 r-xp /usr/lib/libtinycompress.so.0.0.0
44c30000 44c35000 r-xp /usr/lib/libjson.so.0.0.1
44c3d000 44c86000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44c8f000 44cd6000 r-xp /usr/lib/libsndfile.so.1.0.26
44ce2000 44cf1000 r-xp /usr/lib/libmdm-common.so.1.1.22
44cfa000 44d1c000 r-xp /usr/lib/libvorbis.so.0.4.3
44d24000 44d28000 r-xp /usr/lib/libogg.so.0.7.1
44e30000 44e40000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
bef7a000 bef9b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18414)
Call Stack Count: 1
 0: strcmp + 0x4 (0x404f2cb8) [/lib/libc.so.6] + 0x75cb8
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
interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:44:00.526+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:44:00.526+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:44:00.526+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:44:00.526+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4474e030 : elm_scroller] mx(360), my(360), minx(0), miny(0), px(0), py(0)
07-13 10:44:00.526+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4474e030 : elm_scroller] cw(360), ch(360), pw(0), ph(0)
07-13 10:44:00.531+0800 I/efl-extension(18414): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-13 10:44:00.541+0800 E/EFL     (18414): edje<18414> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:44:00.586+0800 E/EFL     (18414): elementary<18414> elc_naviframe.c:2796 _push_transition_cb() item(0x44d81fc0) will transition
07-13 10:44:00.996+0800 E/EFL     (18414): elementary<18414> elc_naviframe.c:1193 _on_item_push_finished() item(0x43710a00) transition finished
07-13 10:44:01.001+0800 E/EFL     (18414): elementary<18414> elc_naviframe.c:1218 _on_item_show_finished() item(0x44d81fc0) transition finished
07-13 10:44:01.011+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:01.011+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:01.011+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:01.011+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:01.011+0800 I/ISE_MULTI(  803): isemain.cpp: slot_set_return_key_disable(1252) > [0;36m[hidden state:true] disabled=0[0m
07-13 10:44:01.011+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1a00002 FAILED!
07-13 10:44:01.011+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1a00002 FAILED!
07-13 10:44:01.016+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
07-13 10:44:01.016+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
07-13 10:44:01.016+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
07-13 10:44:01.016+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
07-13 10:44:01.036+0800 I/ISE_MULTI(  803): isemain.cpp: slot_set_caps_mode(1113) > [0;36m[hidden state:true] mode=1[0m
07-13 10:44:01.081+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:44:01.096+0800 E/EFL     (  462): ecore_x<462> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1a00002 time=52325344
07-13 10:44:01.096+0800 E/EFL     (18414): ecore_x<18414> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=52325344
07-13 10:44:01.096+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=52325344
07-13 10:44:01.131+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:44:01.131+0800 I/ISE_MULTI(  803): ise.cpp: ise_show(2316) > [0;36m--------BEFORE set is_candidate_on-----------[0m
07-13 10:44:01.131+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:44:01.131+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(335) > [0;36m----------START----------[0m
07-13 10:44:01.131+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(347) > [0;36m-------INPUT_MODE_HANDWRITING--------[0m
07-13 10:44:01.131+0800 E/ISE_MULTI(  803): ise-rotary-event-listener.cpp: rotary_input_init(119) > [0;31mrotary_input_init[0m
07-13 10:44:01.136+0800 W/SWIFTKEY(  668): swiftkey_logger.cpp: reportError(44) > [0;33mSKLogger [ File Not Found : Could not read keypress model file at "/opt/usr/share/scim/swiftkey/lang/zh_CN/keyModel_qwerty_port.json" ][0m
07-13 10:44:01.136+0800 W/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Load_keymodel(2368) > [0;33mfail to set the keypress model to /opt/usr/share/scim/swiftkey/lang/zh_CN/keyModel_qwerty_port.json[0m
07-13 10:44:01.146+0800 I/ISE_MULTI(  803): ise.cpp: ise_show(2374) > [0;36m--------------------[0m
07-13 10:44:01.146+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(986) > [0;36m-----candidate_show-----[0m
07-13 10:44:01.146+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1008) > [0;36mcandidate_show:is_chinese = 1[0m
07-13 10:44:01.146+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1034) > [0;36m-----END-----[0m
07-13 10:44:01.171+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:44:01.216+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:44:01.236+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_hide(1039) > [0;36mcandidate_hide[0m
07-13 10:44:01.326+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:44:01.586+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:01.591+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:01.591+0800 E/ISE_MULTI(  803): ise-ui.cpp: indicator_popup_show_cb(1533) > [0;31mindicator_popup_show_cb[0m
07-13 10:44:01.611+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52325930 button=1
07-13 10:44:01.796+0800 E/AUL_AMD (  520): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
07-13 10:44:01.796+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[803] goes to (3)
07-13 10:44:01.836+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [280x300]
07-13 10:44:01.876+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:01.876+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:01.991+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x22]
07-13 10:44:02.026+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:02.026+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:02.041+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:44:02.041+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:44:02.066+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [280x300] -> [360x360]
07-13 10:44:02.116+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=0[0m
07-13 10:44:02.116+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:02.116+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:02.121+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:02.121+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:02.121+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:02.121+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:02.121+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:02.121+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:02.126+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:02.126+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:02.131+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:02.131+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:02.136+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:44:02.136+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:44:02.141+0800 E/EFL     (18414): edje<18414> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:44:02.146+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4474e030 : elm_scroller] mx(360), my(70), minx(0), miny(0), px(0), py(0)
07-13 10:44:02.146+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4474e030 : elm_scroller] cw(360), ch(70), pw(0), ph(0)
07-13 10:44:02.146+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:44:02.146+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:44:02.146+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:02.146+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:02.146+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:44:02.146+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:44:02.156+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:02.156+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:02.156+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:44:02.156+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:44:02.656+0800 E/EFL     (  462): ecore_x<462> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2800077 time=52326476
07-13 10:44:02.656+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=52326476
07-13 10:44:02.681+0800 E/ISE_HWR (  803): handwriting.cpp: efl_ise_recog_timeout(213) > [0;31mEND[0m
07-13 10:44:02.716+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [360x360] -> [280x300]
07-13 10:44:03.196+0800 I/APP_CORE(  806): appcore-efl.c: __do_app(453) > [APP 806] Event: MEM_FLUSH State: PAUSED
07-13 10:44:03.206+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:44:03.206+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:44:03.216+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5480) > [0;36mSK_CMD_HWR_CANDIDATE_STRING[0m
07-13 10:44:03.216+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(0) = .[0m
07-13 10:44:03.216+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(1) = 0[0m
07-13 10:44:03.216+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(2) = ÿ[0m
07-13 10:44:03.216+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(3) = 0[0m
07-13 10:44:03.216+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(4) = o[0m
07-13 10:44:03.216+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5494) > [0;36mbefore update_lookup_table[0m
07-13 10:44:03.221+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:03.221+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:03.226+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 0[0m
07-13 10:44:03.631+0800 I/efl-extension(  806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:44:03.631+0800 I/efl-extension(18414): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:44:03.631+0800 I/efl-extension(18414): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x43710598, elm_image, time_stamp : 52327957
07-13 10:44:03.631+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x436fe7a8 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-13 10:44:03.631+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x436fe7a8 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-13 10:44:03.631+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x436fe7a8 : elm_genlist] x(0), y(130)
07-13 10:44:03.631+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x436fe7a8 : elm_genlist] t_in(0.300000), pos_x(0)
07-13 10:44:03.631+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x436fe7a8 : elm_genlist] t_in(0.300000), pos_y(130)
07-13 10:44:03.631+0800 I/efl-extension(  803): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:44:03.631+0800 E/ISE_MULTI(  803): ise-rotary-event-listener.cpp: _ise_rotary_handler_cb(52) > [0;31m_ise_rotary_handler_cb[0m
07-13 10:44:03.636+0800 W/ISE_MULTI(  803): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [65542][0m
07-13 10:44:03.636+0800 I/efl-extension( 1316): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:44:03.641+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.076199)
07-13 10:44:03.641+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-13 10:44:03.641+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.076199)
07-13 10:44:03.671+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(9)
07-13 10:44:03.676+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.298612)
07-13 10:44:03.676+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(9)
07-13 10:44:03.676+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.298612)
07-13 10:44:03.681+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(38)
07-13 10:44:03.736+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.575700)
07-13 10:44:03.736+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(38)
07-13 10:44:03.736+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.575700)
07-13 10:44:03.736+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(74)
07-13 10:44:03.736+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.590368)
07-13 10:44:03.736+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(74)
07-13 10:44:03.736+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.590368)
07-13 10:44:03.736+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(76)
07-13 10:44:03.756+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.660060)
07-13 10:44:03.756+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(76)
07-13 10:44:03.756+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.660060)
07-13 10:44:03.756+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(85)
07-13 10:44:03.756+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.671535)
07-13 10:44:03.756+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(85)
07-13 10:44:03.756+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.671535)
07-13 10:44:03.761+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(87)
07-13 10:44:03.761+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.681261)
07-13 10:44:03.761+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(87)
07-13 10:44:03.761+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.681261)
07-13 10:44:03.761+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(88)
07-13 10:44:03.761+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.690802)
07-13 10:44:03.761+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(88)
07-13 10:44:03.761+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.690802)
07-13 10:44:03.766+0800 I/efl-extension(  806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:44:03.766+0800 I/efl-extension( 1316): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:44:03.766+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(89)
07-13 10:44:03.771+0800 I/efl-extension(18414): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:44:03.771+0800 I/efl-extension(18414): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x43710598, elm_image, time_stamp : 52328095
07-13 10:44:03.771+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.722094)
07-13 10:44:03.771+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(89)
07-13 10:44:03.771+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.722094)
07-13 10:44:03.771+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(93)
07-13 10:44:03.771+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x436fe7a8 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(93)
07-13 10:44:03.771+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x436fe7a8 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-13 10:44:03.771+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1910 _elm_scroll_content_region_show_internal() [0x436fe7a8 : elm_genlist] scrollto.x.animator(0x41656a00)
07-13 10:44:03.771+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1916 _elm_scroll_content_region_show_internal() [0x436fe7a8 : elm_genlist] scrollto.y.animator(0x41656b40)
07-13 10:44:03.771+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x436fe7a8 : elm_genlist] x(0), y(130)
07-13 10:44:03.771+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x436fe7a8 : elm_genlist] t_in(0.300000), pos_x(0)
07-13 10:44:03.771+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x436fe7a8 : elm_genlist] t_in(0.300000), pos_y(130)
07-13 10:44:03.786+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.095743)
07-13 10:44:03.786+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(93)
07-13 10:44:03.786+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.095743)
07-13 10:44:03.786+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(96)
07-13 10:44:03.801+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.198636)
07-13 10:44:03.801+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(96)
07-13 10:44:03.801+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.198636)
07-13 10:44:03.806+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(100)
07-13 10:44:03.821+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.295446)
07-13 10:44:03.821+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(100)
07-13 10:44:03.821+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.295446)
07-13 10:44:03.821+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(103)
07-13 10:44:03.831+0800 E/ISE_MULTI(  803): rotary_input.cpp: destroy_rotary_input_layout(755) > [0;31mdestroy_rotary_input_layout[0m
07-13 10:44:03.831+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:44:03.831+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(335) > [0;36m----------START----------[0m
07-13 10:44:03.831+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(347) > [0;36m-------INPUT_MODE_HANDWRITING--------[0m
07-13 10:44:03.876+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(986) > [0;36m-----candidate_show-----[0m
07-13 10:44:03.881+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1008) > [0;36mcandidate_show:is_chinese = 1[0m
07-13 10:44:03.881+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1034) > [0;36m-----END-----[0m
07-13 10:44:03.881+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:44:03.886+0800 I/ISE_MULTI(  803): privatekeys.cpp: ise_update_globe_private_key(1819) > [0;36mSystem language is [zh_CN.UTF-8] #####[0m
07-13 10:44:03.901+0800 I/ISE_MULTI(  803): privatekeys.cpp: ise_update_globe_private_key(1819) > [0;36mSystem language is [zh_CN.UTF-8] #####[0m
07-13 10:44:03.926+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:44:03.936+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.466120)
07-13 10:44:03.936+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(103)
07-13 10:44:03.936+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.466120)
07-13 10:44:03.941+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(110)
07-13 10:44:03.941+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.813259)
07-13 10:44:03.941+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(110)
07-13 10:44:03.941+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.813259)
07-13 10:44:03.941+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(123)
07-13 10:44:03.951+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.827120)
07-13 10:44:03.951+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(123)
07-13 10:44:03.951+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.827120)
07-13 10:44:03.951+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(123)
07-13 10:44:03.966+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.839789)
07-13 10:44:03.966+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(123)
07-13 10:44:03.966+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.839789)
07-13 10:44:03.966+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(124)
07-13 10:44:03.966+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.879775)
07-13 10:44:03.966+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(124)
07-13 10:44:03.966+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.879775)
07-13 10:44:03.966+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(125)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.885897)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(125)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.885897)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(125)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.888365)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(125)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.888365)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(125)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.890433)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(125)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.890433)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(125)
07-13 10:44:03.971+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.894361)
07-13 10:44:03.976+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(125)
07-13 10:44:03.976+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.894361)
07-13 10:44:03.976+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(126)
07-13 10:44:03.981+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:03.981+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:03.981+0800 I/efl-extension(  803): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:44:03.981+0800 E/ISE_MULTI(  803): ise-rotary-event-listener.cpp: _ise_rotary_handler_cb(52) > [0;31m_ise_rotary_handler_cb[0m
07-13 10:44:03.986+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:03.986+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:03.986+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.920366)
07-13 10:44:03.986+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(126)
07-13 10:44:03.986+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.920366)
07-13 10:44:03.986+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(127)
07-13 10:44:03.991+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:03.991+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:03.991+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:44:03.991+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:44:04.001+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.947677)
07-13 10:44:04.001+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(127)
07-13 10:44:04.001+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.947677)
07-13 10:44:04.006+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(128)
07-13 10:44:04.021+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.970051)
07-13 10:44:04.021+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(128)
07-13 10:44:04.021+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.970051)
07-13 10:44:04.021+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(128)
07-13 10:44:04.036+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.986926)
07-13 10:44:04.036+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(128)
07-13 10:44:04.036+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.986926)
07-13 10:44:04.036+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-13 10:44:04.051+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.996154)
07-13 10:44:04.051+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-13 10:44:04.051+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.996154)
07-13 10:44:04.051+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-13 10:44:04.071+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.999995)
07-13 10:44:04.071+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-13 10:44:04.071+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.999995)
07-13 10:44:04.071+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-13 10:44:04.086+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] time(0.997234)
07-13 10:44:04.086+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(129)
07-13 10:44:04.086+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] time(0.997234)
07-13 10:44:04.086+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] animation stop!!
07-13 10:44:04.091+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x436fe7a8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-13 10:44:04.681+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52329012 button=1
07-13 10:44:04.731+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:04.731+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:04.731+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: select_candidate(3467) > [0;36mSTART[0m
07-13 10:44:04.731+0800 E/SWIFTKEY(  668): isf_swiftkey_imengine_chinese.cpp: select_candidate_chinese(322) > [0;31m length[0, 0][0m
07-13 10:44:04.846+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:44:04.856+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=2[0m
07-13 10:44:04.856+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:44:04.856+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:44:04.856+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:04.856+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:04.861+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:04.861+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:04.861+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:04.866+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:04.866+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:44:04.866+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:44:05.741+0800 E/EFL     (  462): ecore_x<462> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2800003 time=52329181
07-13 10:44:05.751+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=52329181
07-13 10:44:05.891+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52330221 button=1
07-13 10:44:05.941+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:05.941+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:05.946+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: select_candidate(3467) > [0;36mSTART[0m
07-13 10:44:05.946+0800 E/SWIFTKEY(  668): isf_swiftkey_imengine_chinese.cpp: select_candidate_chinese(322) > [0;31m length[0, 0][0m
07-13 10:44:06.026+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:44:06.036+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=3[0m
07-13 10:44:06.036+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:06.036+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:06.036+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:44:06.036+0800 E/EFL     (18414): elementary<18414> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4474fd90 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:44:06.046+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:06.046+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:06.051+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:06.051+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:06.061+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:44:06.061+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:44:12.206+0800 E/EFL     (18414): ecore_x<18414> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52336477 button=1
07-13 10:44:12.206+0800 E/EFL     (18414): ecore_x<18414> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=52336535 button=1
07-13 10:44:12.216+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:12.216+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:12.221+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:12.221+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:12.231+0800 I/ISE_MULTI(  803): isemain.cpp: slot_reset_ise_input_context(1372) > [0;36m[hidden state:false][0m
07-13 10:44:12.231+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:12.231+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:12.236+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:44:12.236+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:44:12.551+0800 W/CRASH_MANAGER(18532): worker.c: worker_job(1205) > 111841473656e149991385
