S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 2790
Date: 2017-07-12 10:49:55+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2790, uid 5000)

Register Information
r0   = 0xe14604b5, r1   = 0x401dae78
r2   = 0x401bed08, r3   = 0x00001e3c
r4   = 0x401dae78, r5   = 0xe14604b5
r6   = 0x402d4e38, r7   = 0x401bf060
r8   = 0xe14604b5, r9   = 0x44d16e58
r10  = 0x44d1bc00, fp   = 0x00000001
ip   = 0x401f1c28, sp   = 0xbeebc148
lr   = 0x401a358f, pc   = 0x40233e06
cpsr = 0xa0000030

Memory Information
MemTotal:   491132 KB
MemFree:     41068 KB
Buffers:     20472 KB
Cached:     151172 KB
VmPeak:      83752 KB
VmSize:      82224 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23572 KB
VmRSS:       23568 KB
VmData:      18688 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2790 TID = 2790
2790 2902 

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
414be000 414c2000 r-xp /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418bd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
418c8000 418cd000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
418d5000 418e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418ea000 4190b000 r-xp /usr/lib/libefl-extension.so.0.1.0
41913000 41918000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41920000 4194a000 r-xp /usr/lib/libsensor.so.1.9.5
41953000 4195a000 r-xp /usr/lib/libctx-shared.so.0.8.3
41962000 41967000 r-xp /usr/lib/libctx-client.so.0.8.3
4196f000 41981000 r-xp /usr/lib/libefl-assist.so.0.1.0
41989000 41a41000 r-xp /usr/lib/libcairo.so.2.11200.14
41a4c000 41a56000 r-xp /usr/lib/libsensord-shared.so
41a5e000 41a6d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a76000 41a8c000 r-xp /usr/lib/libtts.so
41a95000 41ab8000 r-xp /usr/lib/libui-extension.so.0.1.0
41ac1000 41acc000 r-xp /usr/lib/libtbm.so.1.0.0
41ad4000 41ae2000 r-xp /usr/lib/libGLESv2.so.2.0
41aeb000 41aec000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41af5000 41afb000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b03000 41b06000 r-xp /usr/lib/libEGL.so.1.4
41b0e000 41b11000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b19000 41b1a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41b23000 41cab000 r-xp /usr/lib/libicui18n.so.57.1
41cbb000 41dc1000 r-xp /usr/lib/libicuuc.so.57.1
41dd7000 41ddf000 r-xp /usr/lib/libdrm.so.2.4.0
41de7000 41de9000 r-xp /usr/lib/libdri2.so.0.0.0
41df1000 41df7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41dff000 41e04000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41e0c000 41e25000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
436c6000 436e7000 r-xp /usr/lib/libexif.so.12.3.3
436fa000 436fc000 r-xp /usr/lib/libttrace.so.1.1
43704000 43709000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43711000 43717000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43720000 43728000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43730000 43752000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4375b000 43762000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4376b000 4376d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43775000 4377c000 r-xp /usr/lib/libminizip.so.1.0.0
43784000 43791000 r-xp /usr/lib/libail.so.0.1.0
4379a000 437a0000 r-xp /usr/lib/libproc-stat.so.0.2.96
437a8000 437a9000 r-xp /usr/lib/libresponse.so.0.2.96
437b1000 437b6000 r-xp /usr/lib/libsystem.so.0.0.0
437c0000 4388a000 r-xp /usr/lib/libCOREGL.so.4.0
43c2f000 43c3a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c43000 43c48000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c50000 43c67000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c74000 43c76000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43c7f000 4447e000 rw-p [stack:2902]
4447e000 4447f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444d9000 444da000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
449cd000 449d5000 r-xp /usr/lib/libfeedback.so.0.1.4
449d7000 449d8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
449e0000 449e2000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
449ea000 449f5000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
449fd000 44a04000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44a0c000 44a24000 r-xp /usr/lib/libmmfsound.so.0.1.0
44a35000 44a39000 r-xp /usr/lib/libmmfsession.so.0.0.0
44a42000 44a4d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44a5a000 44a5e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44a66000 44a7c000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44a84000 44ae5000 r-xp /usr/lib/libasound.so.2.0.0
44aef000 44af2000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44afa000 44b32000 r-xp /usr/lib/libpulse.so.0.16.2
44b33000 44b36000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44b3e000 44b86000 r-xp /usr/lib/libmdm.so.1.2.62
44b87000 44b8a000 r-xp /usr/lib/libtinycompress.so.0.0.0
44b92000 44b97000 r-xp /usr/lib/libjson.so.0.0.1
44b9f000 44be8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44bf1000 44c38000 r-xp /usr/lib/libsndfile.so.1.0.26
44c44000 44c53000 r-xp /usr/lib/libmdm-common.so.1.1.22
44c5c000 44c7e000 r-xp /usr/lib/libvorbis.so.0.4.3
44c86000 44c8a000 r-xp /usr/lib/libogg.so.0.7.1
bee9c000 beebd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2790)
Call Stack Count: 21
 0: evas_object_smart_type_check_ptr + 0xd (0x40233e06) [/usr/lib/libevas.so.1] + 0x34e06
 1: elm_widget_type_get + 0xe (0x401a358f) [/usr/lib/libelementary.so.1] + 0xf758f
 2: elm_widget_type_check + 0x10 (0x401a4395) [/usr/lib/libelementary.so.1] + 0xf8395
 3: elm_naviframe_item_pop + 0x24 (0x400f5fbd) [/usr/lib/libelementary.so.1] + 0x49fbd
 4: _button_clicked_cb_return + 0x40 (0x414c0bfd) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2bfd
 5: evas_object_smart_callback_call + 0x88 (0x402345cd) [/usr/lib/libevas.so.1] + 0x355cd
 6: (0x40365f0d) [/usr/lib/libedje.so.1] + 0x45f0d
 7: (0x40369efd) [/usr/lib/libedje.so.1] + 0x49efd
 8: (0x40366869) [/usr/lib/libedje.so.1] + 0x46869
 9: (0x40366c1b) [/usr/lib/libedje.so.1] + 0x46c1b
10: (0x40366d55) [/usr/lib/libedje.so.1] + 0x46d55
11: (0x402fd3f5) [/usr/lib/libecore.so.1] + 0xb3f5
12: (0x402fae53) [/usr/lib/libecore.so.1] + 0x8e53
13: (0x402fe46b) [/usr/lib/libecore.so.1] + 0xc46b
14: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
15: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
16: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
17: main + 0x116 (0x414bfd77) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1d77
18: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
19: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
20: app_pause + 0xb (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
:40.001+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:40.001+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:40.206+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:40.206+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:40.401+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:40.401+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:40.606+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:40.606+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:40.801+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:40.801+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:41.006+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:41.006+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:41.201+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:41.201+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:41.416+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:41.416+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:41.601+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:41.606+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:41.806+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:41.806+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:42.001+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:42.001+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:42.206+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:42.206+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:42.406+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:42.406+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:42.606+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:42.606+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:42.806+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:42.806+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:43.001+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:43.001+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:43.206+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:43.206+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:43.406+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:43.406+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:43.601+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:43.601+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:43.811+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:43.811+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:44.001+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:44.001+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:44.211+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:44.211+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:44.401+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:44.401+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:44.601+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:44.601+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:44.801+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:44.801+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:45.001+0800 W/AUL     ( 2879): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-12 10:49:45.001+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:45.001+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:45.001+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 0
07-12 10:49:45.031+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-12 10:49:45.056+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-12 10:49:45.056+0800 E/AUL_AMD (  524): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-12 10:49:45.056+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(1782) > caller pid : 2879
07-12 10:49:45.071+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(2218) > pad pid(-5)
07-12 10:49:45.076+0800 W/AUL_PAD ( 1308): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-12 10:49:45.076+0800 W/AUL_PAD ( 1308): launchpad.c: __send_result_to_caller(272) > Check app launching
07-12 10:49:45.076+0800 W/AUL_PAD ( 2790): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-12 10:49:45.076+0800 W/AUL_PAD ( 2790): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-12 10:49:45.076+0800 W/AUL_PAD ( 2790): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-12 10:49:45.076+0800 W/AUL_PAD ( 2790): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-12 10:49:45.086+0800 E/RESOURCED(  600): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 1
07-12 10:49:45.151+0800 I/efl-extension( 2790): efl_extension.c: eext_mod_init(40) > Init
07-12 10:49:45.156+0800 I/UXT     ( 2790): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-12 10:49:45.171+0800 W/AUL_PAD ( 2790): launchpad_loader.c: main(690) > [candidate] dlsym
07-12 10:49:45.171+0800 W/AUL_PAD ( 2790): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-12 10:49:45.171+0800 I/CAPI_APPFW_APPLICATION( 2790): app_main.c: ui_app_main(704) > app_efl_main
07-12 10:49:45.176+0800 I/CAPI_APPFW_APPLICATION( 2790): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-12 10:49:45.201+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:45.201+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:45.276+0800 W/AUL     (  524): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(2790) type(uiapp) bg(0)
07-12 10:49:45.276+0800 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (2790) was created
07-12 10:49:45.281+0800 W/AUL     ( 2879): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2790)
07-12 10:49:45.281+0800 W/STARTER (  754): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [2790]
07-12 10:49:45.391+0800 I/efl-extension( 2790): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 10:49:45.391+0800 I/efl-extension( 2790): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-12 10:49:45.391+0800 I/efl-extension( 2790): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-12 10:49:45.396+0800 I/efl-extension( 2790): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-12 10:49:45.396+0800 I/efl-extension( 2790): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445062a8, elm_image, _activated_obj : 0x0, activated : 1
07-12 10:49:45.396+0800 E/EFL     ( 2790): elementary<2790> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 10:49:45.401+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:45.401+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:45.406+0800 E/EFL     ( 2790): elementary<2790> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44506710) will be pushed
07-12 10:49:45.406+0800 I/efl-extension( 2790): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x41881198]'s widget[0x44507ba0] to layout widget[0x44506710]
07-12 10:49:45.411+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 10:49:45.411+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-12 10:49:45.411+0800 I/efl-extension( 2790): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 10:49:45.421+0800 I/APP_CORE( 2790): appcore-efl.c: __do_app(453) > [APP 2790] Event: RESET State: CREATED
07-12 10:49:45.421+0800 I/CAPI_APPFW_APPLICATION( 2790): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-12 10:49:45.466+0800 W/W_HOME  (  811): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-12 10:49:45.466+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 10:49:45.466+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 10:49:45.471+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 10:49:45.471+0800 W/W_HOME  (  811): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-12 10:49:45.481+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 10:49:45.481+0800 I/APP_CORE( 2790): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-12 10:49:45.481+0800 I/APP_CORE( 2790): appcore-efl.c: __do_app(524) > [APP 2790] Initial Launching, call the resume_cb
07-12 10:49:45.481+0800 I/CAPI_APPFW_APPLICATION( 2790): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-12 10:49:45.491+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 10:49:45.496+0800 I/MALI    (  811): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-12 10:49:45.511+0800 W/APP_CORE( 2790): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1600002
07-12 10:49:45.516+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 10:49:45.516+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-12 10:49:45.551+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-12 10:49:45.551+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-12 10:49:45.596+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 10:49:45.596+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 10:49:45.606+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-12 10:49:45.606+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-12 10:49:45.606+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 10:49:45.606+0800 W/W_HOME  (  811): event_manager.c: _state_control(326) > appcore paused manually
07-12 10:49:45.606+0800 W/W_HOME  (  811): main.c: home_appcore_pause(514) > Home Appcore Paused
07-12 10:49:45.606+0800 W/W_HOME  (  811): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-12 10:49:45.606+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 10:49:45.606+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 10:49:45.606+0800 W/W_HOME  (  811): main.c: home_pause(546) > clock/widget paused
07-12 10:49:45.606+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 10:49:45.606+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 10:49:45.606+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 10:49:45.606+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 10:49:45.606+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-12 10:49:45.606+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-12 10:49:45.606+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 10:49:45.606+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 10:49:45.606+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 10:49:45.611+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 10:49:45.611+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 10:49:45.611+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 10:49:45.611+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-12 10:49:45.611+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-12 10:49:45.611+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 10:49:45.611+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 10:49:45.611+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-12 10:49:45.611+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-12 10:49:45.611+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 10:49:45.611+0800 E/CAPI_APPFW_APP_CONTROL( 1005): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-12 10:49:45.611+0800 W/MUSIC_CONTROL_SERVICE( 1005): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1005]   [com.samsung.w-home]register msg port [false][0m
07-12 10:49:45.611+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 10:49:45.611+0800 W/W_HOME  (  811): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-12 10:49:45.611+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: PAUSE State: RUNNING
07-12 10:49:45.611+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(811) status(bg) type(uiapp)
07-12 10:49:45.611+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[811] goes to (4)
07-12 10:49:45.611+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 811)'s state(4)
07-12 10:49:45.616+0800 I/CAPI_APPFW_APPLICATION(  811): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-12 10:49:45.616+0800 W/W_HOME  (  811): main.c: _appcore_pause_cb(487) > appcore pause
07-12 10:49:45.616+0800 E/W_HOME  (  811): main.c: _pause_cb(465) > paused already
07-12 10:49:45.616+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-12 10:49:45.616+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 10:49:45.616+0800 W/wnotib  (  811): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-12 10:49:45.626+0800 W/WATCH_CORE(  901): appcore-watch.c: __widget_pause(1113) > widget_pause
07-12 10:49:45.626+0800 W/AUL     (  901): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(901) status(bg) type(watchapp)
07-12 10:49:45.626+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppPause(589) > 
07-12 10:49:45.636+0800 I/APP_CORE( 2790): appcore-efl.c: __do_app(453) > [APP 2790] Event: RESUME State: RUNNING
07-12 10:49:45.641+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 10:49:45.641+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 10:49:45.646+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2790] goes to (3)
07-12 10:49:45.646+0800 W/AUL_AMD (  524): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-12 10:49:45.646+0800 W/AUL_AMD (  524): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-12 10:49:45.646+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(2790) status(fg) type(uiapp)
07-12 10:49:46.021+0800 E/AUL     (  524): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-12 10:49:46.111+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 10:49:46.576+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 10:49:46.586+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2790
07-12 10:49:46.591+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 10:49:46.621+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 10:49:46.631+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2790
07-12 10:49:46.631+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 10:49:46.911+0800 I/AUL_PAD ( 2882): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-12 10:49:49.521+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1315954 button=1
07-12 10:49:49.521+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1315956 button=1
07-12 10:49:49.521+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:49.531+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-12 10:49:49.531+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-12 10:49:49.531+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] x(0), y(130)
07-12 10:49:49.531+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x417e96d8 : elm_genlist] t_in(0.300000), pos_x(0)
07-12 10:49:49.531+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x417e96d8 : elm_genlist] t_in(0.300000), pos_y(130)
07-12 10:49:49.541+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.110849)
07-12 10:49:49.541+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-12 10:49:49.541+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.110849)
07-12 10:49:49.541+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(14)
07-12 10:49:49.856+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.986187)
07-12 10:49:49.861+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(14)
07-12 10:49:49.861+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.986187)
07-12 10:49:49.861+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] animation stop!!
07-12 10:49:49.861+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-12 10:49:49.901+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1316332 button=1
07-12 10:49:49.906+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:49.906+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:49.906+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:49.946+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:49.946+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:49.946+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:49.946+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:49.946+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:49.946+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] add hold animator
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] direction_x(0), direction_y(1)
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] drag_child_locked_y(0)
07-12 10:49:49.986+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] move content x(0), y(227)
07-12 10:49:50.026+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:50.026+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:50.026+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:50.026+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:50.026+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:50.026+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:50.026+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] direction_x(0), direction_y(1)
07-12 10:49:50.031+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] drag_child_locked_y(0)
07-12 10:49:50.031+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] move content x(0), y(315)
07-12 10:49:50.066+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1316473 button=1
07-12 10:49:50.066+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:50.066+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:50.621+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 10:49:50.686+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1317121 button=1
07-12 10:49:50.686+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:50.691+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:50.691+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:50.726+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 10:49:50.726+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 10:49:50.736+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1317170 button=1
07-12 10:49:50.816+0800 I/efl-extension( 2790): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 10:49:50.816+0800 I/efl-extension( 2790): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4187e7f0, elm_image, _activated_obj : 0x445062a8, activated : 1
07-12 10:49:50.816+0800 I/efl-extension( 2790): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 10:49:50.836+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447fdad0 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-12 10:49:50.836+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447fdad0 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-12 10:49:50.861+0800 E/EFL     ( 2790): elementary<2790> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 10:49:50.866+0800 E/EFL     ( 2790): elementary<2790> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44827850) will be pushed
07-12 10:49:50.866+0800 I/efl-extension( 2790): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44d30fd0]'s widget[0x44d2b6d0] to layout widget[0x44827850]
07-12 10:49:50.871+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447fdad0 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 10:49:50.871+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447fdad0 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 10:49:50.871+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447fdad0 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 10:49:50.871+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447fdad0 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 10:49:50.871+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447fdad0 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 10:49:50.871+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447fdad0 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 10:49:50.876+0800 I/efl-extension( 2790): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 10:49:50.901+0800 E/EFL     ( 2790): elementary<2790> elc_naviframe.c:2796 _push_transition_cb() item(0x44827850) will transition
07-12 10:49:51.321+0800 E/EFL     ( 2790): elementary<2790> elc_naviframe.c:1193 _on_item_push_finished() item(0x44506710) transition finished
07-12 10:49:51.321+0800 E/EFL     ( 2790): elementary<2790> elc_naviframe.c:1218 _on_item_show_finished() item(0x44827850) transition finished
07-12 10:49:52.591+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1319019 button=1
07-12 10:49:52.591+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:52.591+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:52.591+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:52.591+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:52.591+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:52.591+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:52.591+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:52.591+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] add hold animator
07-12 10:49:52.596+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:52.596+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:52.601+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] direction_x(0), direction_y(1)
07-12 10:49:52.601+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] drag_child_locked_y(0)
07-12 10:49:52.601+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] move content x(0), y(94)
07-12 10:49:52.621+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1319055 button=1
07-12 10:49:52.626+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:52.626+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:52.661+0800 I/efl-extension( 2790): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x447fdad0 : elm_scroller] detent_count(0)
07-12 10:49:52.661+0800 I/efl-extension( 2790): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x447fdad0 : elm_scroller] pagenumber_v(0), pagenumber_h(0)
07-12 10:49:53.246+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1319679 button=1
07-12 10:49:53.246+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.251+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.251+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.261+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.261+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.271+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.271+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.286+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.286+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.296+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.296+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.296+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] add hold animator
07-12 10:49:53.296+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] direction_x(0), direction_y(1)
07-12 10:49:53.301+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] drag_child_locked_y(0)
07-12 10:49:53.301+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] move content x(0), y(222)
07-12 10:49:53.321+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.321+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.321+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.321+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.321+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] direction_x(0), direction_y(1)
07-12 10:49:53.321+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] drag_child_locked_y(0)
07-12 10:49:53.321+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] move content x(0), y(161)
07-12 10:49:53.346+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.346+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.346+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.346+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.346+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] direction_x(0), direction_y(1)
07-12 10:49:53.346+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] drag_child_locked_y(0)
07-12 10:49:53.346+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x447fdad0 : elm_scroller] move content x(0), y(75)
07-12 10:49:53.371+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1319796 button=1
07-12 10:49:53.371+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.371+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.391+0800 I/efl-extension( 2790): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x447fdad0 : elm_scroller] detent_count(0)
07-12 10:49:53.391+0800 I/efl-extension( 2790): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x447fdad0 : elm_scroller] pagenumber_v(0), pagenumber_h(0)
07-12 10:49:53.841+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1320241 button=1
07-12 10:49:53.841+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1320277 button=1
07-12 10:49:53.846+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.846+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.846+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.846+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.846+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.846+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:53.846+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:53.846+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:54.286+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1320654 button=1
07-12 10:49:54.291+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1320722 button=1
07-12 10:49:54.291+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:54.291+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:54.291+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:54.291+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:54.291+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:54.291+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] mouse move
07-12 10:49:54.291+0800 E/EFL     ( 2790): elementary<2790> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x447fdad0 : elm_scroller] hold(0), freeze(0)
07-12 10:49:55.076+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1321506 button=1
07-12 10:49:55.076+0800 E/EFL     ( 2790): ecore_x<2790> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1321508 button=1
07-12 10:49:55.431+0800 W/CRASH_MANAGER( 2923): worker.c: worker_job(1205) > 110279073656e149982779
