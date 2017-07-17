S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 6651
Date: 2017-07-11 20:55:16+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6651, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4472c030, r3   = 0x00000000
r4   = 0x4138db70, r5   = 0x4472c030
r6   = 0xbeb43d10, r7   = 0x405ab000
r8   = 0x00000000, r9   = 0x40458824
r10  = 0x413c13fc, fp   = 0xbeb43cfc
ip   = 0x00000000, sp   = 0xbeb43790
lr   = 0x404bb0ec, pc   = 0x404bb054
cpsr = 0x40000010

Memory Information
MemTotal:   491132 KB
MemFree:      3148 KB
Buffers:     31656 KB
Cached:     162492 KB
VmPeak:     109948 KB
VmSize:     107912 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24440 KB
VmRSS:       24440 KB
VmData:      44376 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6651 TID = 6651
6651 6775 6790 6791 6792 

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
416c8000 416cd000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
416d5000 416e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
416ea000 4170b000 r-xp /usr/lib/libefl-extension.so.0.1.0
41713000 41718000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41720000 4174a000 r-xp /usr/lib/libsensor.so.1.9.5
41753000 4175a000 r-xp /usr/lib/libctx-shared.so.0.8.3
41762000 41767000 r-xp /usr/lib/libctx-client.so.0.8.3
4176f000 41781000 r-xp /usr/lib/libefl-assist.so.0.1.0
41789000 41841000 r-xp /usr/lib/libcairo.so.2.11200.14
4184c000 41856000 r-xp /usr/lib/libsensord-shared.so
4185e000 4186d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41876000 4188c000 r-xp /usr/lib/libtts.so
41895000 418b8000 r-xp /usr/lib/libui-extension.so.0.1.0
418c1000 418cc000 r-xp /usr/lib/libtbm.so.1.0.0
418d4000 418e2000 r-xp /usr/lib/libGLESv2.so.2.0
418eb000 418ec000 r-xp /usr/lib/libxcb-shm.so.0.0.0
418f5000 418fb000 r-xp /usr/lib/libxcb-render.so.0.0.0
41903000 41906000 r-xp /usr/lib/libEGL.so.1.4
4190e000 41911000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41919000 4191a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41923000 41aab000 r-xp /usr/lib/libicui18n.so.57.1
41abb000 41bc1000 r-xp /usr/lib/libicuuc.so.57.1
41bd7000 41bdf000 r-xp /usr/lib/libdrm.so.2.4.0
41be7000 41be9000 r-xp /usr/lib/libdri2.so.0.0.0
41bf1000 41bf7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41bff000 41c04000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41c0c000 41c25000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41c2d000 41c4e000 r-xp /usr/lib/libexif.so.12.3.3
41c61000 41c63000 r-xp /usr/lib/libttrace.so.1.1
41c6b000 41c70000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41c78000 41c7e000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41c87000 41c8f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41c97000 41cb9000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41cc2000 41cc9000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41cd2000 41cd4000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41cdc000 41ce3000 r-xp /usr/lib/libminizip.so.1.0.0
41ceb000 41cf8000 r-xp /usr/lib/libail.so.0.1.0
41d01000 41d07000 r-xp /usr/lib/libproc-stat.so.0.2.96
41d0f000 41d10000 r-xp /usr/lib/libresponse.so.0.2.96
41d18000 41d1d000 r-xp /usr/lib/libsystem.so.0.0.0
41d27000 41d32000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41d3b000 41d40000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41d48000 41d49000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
41d51000 41e85000 rw-p [heap]
4371e000 437e8000 r-xp /usr/lib/libCOREGL.so.4.0
43c8d000 43ca4000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43cb1000 43cb3000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43cbc000 444bb000 rw-p [stack:6775]
444cd000 444ce000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444ec000 444f4000 r-xp /usr/lib/libfeedback.so.0.1.4
444f6000 444f7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44acb000 44acd000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44ad5000 44ae0000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44ae8000 44aef000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44af7000 44b0f000 r-xp /usr/lib/libmmfsound.so.0.1.0
44b20000 44b24000 r-xp /usr/lib/libmmfsession.so.0.0.0
44b2d000 44b38000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44b45000 44b49000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44b51000 44b67000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44b6f000 44bd0000 r-xp /usr/lib/libasound.so.2.0.0
44bda000 44bdd000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44be5000 44c1d000 r-xp /usr/lib/libpulse.so.0.16.2
44c1e000 44c21000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44c29000 44c71000 r-xp /usr/lib/libmdm.so.1.2.62
44c72000 44c75000 r-xp /usr/lib/libtinycompress.so.0.0.0
44c7d000 44c82000 r-xp /usr/lib/libjson.so.0.0.1
44c8a000 44cd3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44cdc000 44d23000 r-xp /usr/lib/libsndfile.so.1.0.26
44d2f000 44d3e000 r-xp /usr/lib/libmdm-common.so.1.1.22
44d47000 44d69000 r-xp /usr/lib/libvorbis.so.0.4.3
44d71000 44d75000 r-xp /usr/lib/libogg.so.0.7.1
4507e000 4587d000 rw-p [stack:6790]
4587e000 4607d000 rw-p [stack:6791]
4607e000 46900000 rw-p [stack:6792]
beb24000 beb45000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6651)
Call Stack Count: 18
 0: _IO_vfprintf + 0x184 (0x404bb054) [/lib/libc.so.6] + 0x3e054
 1: _IO_fprintf + 0x1c (0x404c4478) [/lib/libc.so.6] + 0x47478
 2: _data_collection + 0x2a (0x413c10bf) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x30bf
 3: _new_acceleartion_value + 0x86 (0x413c1083) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x3083
 4: (0x416de127) [/usr/lib/libcapi-system-sensor.so.0] + 0x9127
 5: (0x41734af0) [/usr/lib/libsensor.so.1] + 0x14af0
 6: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 7: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 8: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
 9: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
10: (0x402fe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
11: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
13: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x116 (0x413bfd1f) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1d1f
15: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
16: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
17: ui_app_lang_changed + 0x3 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
.700+0800 E/MALI    ( 6650): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-11 20:54:39.795+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:39.795+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:40.000+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:40.000+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:40.030+0800 E/PKGMGR_SERVER( 6639): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-11 20:54:40.200+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:40.200+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:40.395+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:40.395+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:40.600+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:40.600+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:40.640+0800 I/MALI    ( 6650): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-11 20:54:40.640+0800 E/MALI    ( 6650): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-11 20:54:40.675+0800 I/AUL     ( 6657): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-11 20:54:40.690+0800 I/AUL     ( 6657): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 20:54:40.690+0800 E/AUL     ( 6657): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 20:54:40.695+0800 E/AUL     ( 6657): aul_path.c: __get_path(169) > root_path is NULL!
07-11 20:54:40.795+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:40.800+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:40.995+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:40.995+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:41.200+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:41.200+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:41.405+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:41.405+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:41.500+0800 E/rpm-installer( 6640): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-11 20:54:41.500+0800 E/rpm-installer( 6640): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-11 20:54:41.500+0800 E/rpm-installer( 6640): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-11 20:54:41.520+0800 E/PKGMGR_SERVER( 6639): pkgmgr-server.c: sighandler(486) > child NORMAL exit [6640]
07-11 20:54:41.575+0800 E/RESOURCED(  630): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/6640/oom_score_adj failed
07-11 20:54:41.575+0800 E/RESOURCED(  630): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 6640
07-11 20:54:41.595+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:41.595+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:41.805+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:41.805+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:42.005+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:42.005+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:42.030+0800 E/PKGMGR_SERVER( 6639): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-11 20:54:42.030+0800 E/PKGMGR_SERVER( 6639): pkgmgr-server.c: main(2296) > package manager server terminated.
07-11 20:54:42.200+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:42.200+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:42.395+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:42.395+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:42.600+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:42.600+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:42.805+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:42.805+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:43.000+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:43.000+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:43.200+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:43.200+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:43.360+0800 W/WATCH_CORE(  934): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
07-11 20:54:43.365+0800 W/STARTER (  754): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
07-11 20:54:43.365+0800 W/STARTER (  754): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
07-11 20:54:43.365+0800 E/STARTER (  754): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
07-11 20:54:43.365+0800 W/STARTER (  754): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
07-11 20:54:43.365+0800 W/STARTER (  754): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
07-11 20:54:43.380+0800 W/WAKEUP-SERVICE( 1251): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : 1075006220[0;m
07-11 20:54:43.380+0800 W/WAKEUP-SERVICE( 1251): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
07-11 20:54:43.380+0800 W/WAKEUP-SERVICE( 1251): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
07-11 20:54:43.385+0800 E/WAKEUP-SERVICE( 1251): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
07-11 20:54:43.390+0800 E/WAKEUP-SERVICE( 1251): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
07-11 20:54:43.390+0800 I/TIZEN_N_SOUND_MANAGER( 1251): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
07-11 20:54:43.395+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:43.395+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:43.400+0800 I/TIZEN_N_SOUND_MANAGER( 1251): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
07-11 20:54:43.405+0800 W/TIZEN_N_SOUND_MANAGER( 1251): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
07-11 20:54:43.405+0800 W/WAKEUP-SERVICE( 1251): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
07-11 20:54:43.405+0800 I/HIGEAR  ( 1251): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
07-11 20:54:43.460+0800 W/SHealthCommon( 1108): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
07-11 20:54:43.460+0800 W/SHealthService( 1108): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
07-11 20:54:43.465+0800 W/SHealthCommon(  937): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
07-11 20:54:43.465+0800 W/W_INDICATOR(  755): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
07-11 20:54:43.475+0800 W/W_HOME  (  807): dbus.c: _dbus_message_recv_cb(204) > LCD off
07-11 20:54:43.475+0800 W/W_HOME  (  807): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
07-11 20:54:43.475+0800 W/W_HOME  (  807): gesture.c: _manual_render_disable_timer_del(157) > timer del
07-11 20:54:43.475+0800 W/W_HOME  (  807): gesture.c: _manual_render_enable(138) > 1
07-11 20:54:43.475+0800 W/W_HOME  (  807): event_manager.c: _lcd_off_cb(729) > lcd state: 0
07-11 20:54:43.480+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 20:54:43.490+0800 W/STARTER (  754): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
07-11 20:54:43.490+0800 W/STARTER (  754): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
07-11 20:54:43.490+0800 W/STARTER (  754): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
07-11 20:54:43.490+0800 W/STARTER (  754): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
07-11 20:54:43.495+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: PAUSE State: RUNNING
07-11 20:54:43.495+0800 I/CAPI_APPFW_APPLICATION(  807): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-11 20:54:43.495+0800 W/W_HOME  (  807): main.c: _appcore_pause_cb(487) > appcore pause
07-11 20:54:43.495+0800 W/W_HOME  (  807): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-11 20:54:43.495+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 20:54:43.495+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 20:54:43.495+0800 W/W_HOME  (  807): main.c: home_pause(546) > clock/widget paused
07-11 20:54:43.495+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-11 20:54:43.495+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-11 20:54:43.495+0800 E/CAPI_APPFW_APP_CONTROL( 1014): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-11 20:54:43.495+0800 W/MUSIC_CONTROL_SERVICE( 1014): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1014]   [com.samsung.w-home]register msg port [false][0m
07-11 20:54:43.500+0800 W/W_INDICATOR(  755): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
07-11 20:54:43.500+0800 W/W_INDICATOR(  755): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
07-11 20:54:43.500+0800 W/W_INDICATOR(  755): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
07-11 20:54:43.505+0800 W/WATCH_CORE(  934): appcore-watch.c: __widget_pause(1113) > widget_pause
07-11 20:54:43.505+0800 W/AUL     (  934): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(934) status(bg) type(watchapp)
07-11 20:54:43.510+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppPause(589) > 
07-11 20:54:43.515+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-11 20:54:43.515+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-11 20:54:44.000+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: MEM_FLUSH State: PAUSED
07-11 20:54:48.010+0800 W/AUL     ( 6741): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-11 20:54:48.010+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 0
07-11 20:54:48.040+0800 I/AUL_AMD (  522): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-11 20:54:48.070+0800 I/AUL_AMD (  522): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-11 20:54:48.070+0800 E/AUL_AMD (  522): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-11 20:54:48.070+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(1782) > caller pid : 6741
07-11 20:54:48.090+0800 E/RESOURCED(  630): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 1
07-11 20:54:48.090+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(2218) > pad pid(-5)
07-11 20:54:48.095+0800 W/AUL_PAD ( 1295): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-11 20:54:48.095+0800 W/AUL_PAD ( 1295): launchpad.c: __send_result_to_caller(272) > Check app launching
07-11 20:54:48.100+0800 W/AUL_PAD ( 6651): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-11 20:54:48.100+0800 W/AUL_PAD ( 6651): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-11 20:54:48.100+0800 W/AUL_PAD ( 6651): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-11 20:54:48.100+0800 W/AUL_PAD ( 6651): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-11 20:54:48.185+0800 I/efl-extension( 6651): efl_extension.c: eext_mod_init(40) > Init
07-11 20:54:48.190+0800 I/UXT     ( 6651): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-11 20:54:48.205+0800 W/AUL_PAD ( 6651): launchpad_loader.c: main(690) > [candidate] dlsym
07-11 20:54:48.205+0800 W/AUL_PAD ( 6651): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-11 20:54:48.205+0800 I/CAPI_APPFW_APPLICATION( 6651): app_main.c: ui_app_main(704) > app_efl_main
07-11 20:54:48.210+0800 I/CAPI_APPFW_APPLICATION( 6651): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-11 20:54:48.300+0800 W/AUL     (  522): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(6651) type(uiapp) bg(0)
07-11 20:54:48.300+0800 W/AUL_AMD (  522): amd_status.c: __socket_monitor_cb(1277) > (6651) was created
07-11 20:54:48.300+0800 W/AUL     ( 6741): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6651)
07-11 20:54:48.300+0800 W/STARTER (  754): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6651]
07-11 20:54:48.450+0800 I/efl-extension( 6651): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 20:54:48.455+0800 I/efl-extension( 6651): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-11 20:54:48.455+0800 I/efl-extension( 6651): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-11 20:54:48.455+0800 I/efl-extension( 6651): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-11 20:54:48.455+0800 I/efl-extension( 6651): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445074b8, elm_image, _activated_obj : 0x0, activated : 1
07-11 20:54:48.455+0800 E/EFL     ( 6651): elementary<6651> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 20:54:48.465+0800 E/EFL     ( 6651): elementary<6651> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44507920) will be pushed
07-11 20:54:48.465+0800 I/efl-extension( 6651): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x4380c7a8]'s widget[0x44508db0] to layout widget[0x44507920]
07-11 20:54:48.465+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437fe910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 20:54:48.465+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437fe910 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-11 20:54:48.465+0800 I/efl-extension( 6651): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 20:54:48.475+0800 I/APP_CORE( 6651): appcore-efl.c: __do_app(453) > [APP 6651] Event: RESET State: CREATED
07-11 20:54:48.475+0800 I/CAPI_APPFW_APPLICATION( 6651): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-11 20:54:48.500+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: MEM_FLUSH State: PAUSED
07-11 20:54:48.505+0800 W/W_HOME  (  807): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-11 20:54:48.505+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 20:54:48.505+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 20:54:48.510+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-11 20:54:48.515+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 20:54:48.515+0800 W/W_HOME  (  807): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-11 20:54:48.515+0800 I/APP_CORE( 6651): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-11 20:54:48.515+0800 I/APP_CORE( 6651): appcore-efl.c: __do_app(524) > [APP 6651] Initial Launching, call the resume_cb
07-11 20:54:48.515+0800 I/CAPI_APPFW_APPLICATION( 6651): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-11 20:54:48.520+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-11 20:54:48.545+0800 W/APP_CORE( 6651): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400002
07-11 20:54:48.545+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437fe910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 20:54:48.550+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437fe910 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-11 20:54:48.585+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437fe910 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-11 20:54:48.585+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437fe910 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-11 20:54:48.655+0800 W/W_HOME  (  807): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-11 20:54:48.655+0800 W/W_HOME  (  807): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-11 20:54:48.655+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 20:54:48.655+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 20:54:48.655+0800 W/W_HOME  (  807): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-11 20:54:48.655+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: PAUSE State: PAUSED
07-11 20:54:48.655+0800 I/APP_CORE(  807): appcore-efl.c: __visibility_cb(949) > LCD status is off, skip the AE_RESUME event
07-11 20:54:48.655+0800 I/wnotib  (  807): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-11 20:54:48.655+0800 E/wnotib  (  807): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-11 20:54:48.655+0800 W/wnotib  (  807): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-11 20:54:48.660+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(807) status(bg) type(uiapp)
07-11 20:54:48.665+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[807] goes to (4)
07-11 20:54:48.665+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 807)'s state(4)
07-11 20:54:48.665+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[6651] goes to (3)
07-11 20:54:48.665+0800 W/AUL_AMD (  522): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-11 20:54:48.665+0800 W/AUL_AMD (  522): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-11 20:54:48.665+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(6651) status(fg) type(uiapp)
07-11 20:54:48.720+0800 I/APP_CORE( 6651): appcore-efl.c: __do_app(453) > [APP 6651] Event: RESUME State: RUNNING
07-11 20:54:49.055+0800 E/AUL     (  522): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-11 20:54:49.540+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 20:54:49.550+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6651
07-11 20:54:49.555+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 20:54:49.585+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 20:54:49.595+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6651
07-11 20:54:49.595+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 20:54:49.900+0800 I/AUL_PAD ( 6748): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-11 20:54:56.515+0800 W/SHealthCommon(  937): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
07-11 20:54:56.600+0800 W/WATCH_CORE(  934): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
07-11 20:54:56.600+0800 I/WATCH_CORE(  934): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
07-11 20:54:56.600+0800 I/CAPI_WATCH_APPLICATION(  934): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 20:54:56.600+0800 E/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 20:54:56.600+0800 I/watchface-loader(  934): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-11 20:54:56.600+0800 I/WATCH_CORE(  934): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
07-11 20:54:56.615+0800 W/W_HOME  (  807): dbus.c: _dbus_message_recv_cb(186) > LCD on
07-11 20:54:56.615+0800 W/W_HOME  (  807): gesture.c: _manual_render_disable_timer_set(167) > timer set
07-11 20:54:56.615+0800 W/W_HOME  (  807): gesture.c: _manual_render_disable_timer_del(157) > timer del
07-11 20:54:56.615+0800 W/W_HOME  (  807): gesture.c: _apps_status_get(128) > apps status:0
07-11 20:54:56.615+0800 W/W_HOME  (  807): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:13154
07-11 20:54:56.615+0800 W/W_HOME  (  807): gesture.c: _manual_render_schedule(209) > schedule, manual render
07-11 20:54:56.615+0800 W/W_HOME  (  807): event_manager.c: _lcd_on_cb(721) > lcd state: 1
07-11 20:54:56.615+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 20:54:56.615+0800 W/STARTER (  754): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [powerkey] after screen off time [13154]ms
07-11 20:54:56.615+0800 W/STARTER (  754): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
07-11 20:54:56.635+0800 I/APP_CORE( 6651): appcore-efl.c: __do_app(453) > [APP 6651] Event: RESUME State: RUNNING
07-11 20:54:56.650+0800 W/W_HOME  (  807): gesture.c: _widget_updated_cb(188) > widget updated
07-11 20:54:56.650+0800 W/W_HOME  (  807): gesture.c: _manual_render_disable_timer_del(157) > timer del
07-11 20:54:56.650+0800 W/W_HOME  (  807): gesture.c: _manual_render(182) > 
07-11 20:54:56.695+0800 I/MALI    (  807): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-11 20:54:56.705+0800 W/STARTER (  754): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [powerkey]
07-11 20:54:56.705+0800 W/STARTER (  754): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
07-11 20:54:56.725+0800 W/W_HOME  (  807): gesture.c: _manual_render(182) > 
07-11 20:54:56.755+0800 W/WAKEUP-SERVICE( 1251): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : 1075006220[0;m
07-11 20:54:56.755+0800 W/WAKEUP-SERVICE( 1251): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
07-11 20:54:56.755+0800 W/WAKEUP-SERVICE( 1251): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
07-11 20:54:56.755+0800 I/TIZEN_N_SOUND_MANAGER( 1251): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
07-11 20:54:56.760+0800 W/W_HOME  (  807): gesture.c: _manual_render_enable(138) > 0
07-11 20:54:56.760+0800 W/W_INDICATOR(  755): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
07-11 20:54:56.765+0800 W/SHealthCommon( 1108): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
07-11 20:54:56.770+0800 W/TIZEN_N_SOUND_MANAGER( 1251): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
07-11 20:54:56.770+0800 W/SHealthService( 1108): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
07-11 20:54:56.770+0800 E/WAKEUP-SERVICE( 1251): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
07-11 20:54:56.770+0800 E/WAKEUP-SERVICE( 1251): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
07-11 20:54:56.770+0800 I/TIZEN_N_SOUND_MANAGER( 1251): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
07-11 20:54:56.775+0800 W/W_INDICATOR(  755): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[powerkey],charge : 0, connected : 0
07-11 20:54:56.775+0800 W/SHealthService( 1108): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-11 20:54:56.785+0800 I/TIZEN_N_SOUND_MANAGER( 1251): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
07-11 20:54:56.785+0800 W/TIZEN_N_SOUND_MANAGER( 1251): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
07-11 20:54:56.785+0800 W/WAKEUP-SERVICE( 1251): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
07-11 20:54:56.785+0800 I/HIGEAR  ( 1251): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
07-11 20:54:56.805+0800 E/SHealthService( 1108): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-11 20:54:56.835+0800 W/SHealthService( 1108): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-11 20:54:56.845+0800 W/SHealthService( 1108): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-11 20:54:56.855+0800 W/SHealthCommon( 1108): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499731200000.000000[0;m
07-11 20:54:56.880+0800 W/SHealthCommon( 1108): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-11 20:54:56.885+0800 I/HealthDataService(  998): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-11 20:54:56.900+0800 I/healthData( 1108): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-11 20:54:57.280+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-11 20:54:57.695+0800 E/EFL     ( 6651): ecore_x<6651> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5281666 button=1
07-11 20:54:57.695+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.695+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.695+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.705+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.705+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.705+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] add hold animator
07-11 20:54:57.715+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] direction_x(1), direction_y(1)
07-11 20:54:57.715+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3871 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] drag_child_locked_x(0)
07-11 20:54:57.715+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] drag_child_locked_y(0)
07-11 20:54:57.715+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] move content x(35), y(53)
07-11 20:54:57.765+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.765+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.765+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.765+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.765+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.765+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.770+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.770+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.770+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.770+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.775+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] direction_x(1), direction_y(1)
07-11 20:54:57.775+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3871 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] drag_child_locked_x(0)
07-11 20:54:57.775+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] drag_child_locked_y(0)
07-11 20:54:57.775+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] move content x(62), y(160)
07-11 20:54:57.835+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.835+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.835+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.835+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.835+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.835+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.840+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.840+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.840+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.840+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.840+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:57.840+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:57.840+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] direction_x(1), direction_y(1)
07-11 20:54:57.840+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3871 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] drag_child_locked_x(0)
07-11 20:54:57.840+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] drag_child_locked_y(0)
07-11 20:54:57.845+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x437fe910 : elm_genlist] move content x(82), y(241)
07-11 20:54:57.875+0800 E/EFL     ( 6651): ecore_x<6651> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5281807 button=1
07-11 20:54:58.650+0800 E/EFL     ( 6651): ecore_x<6651> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5282622 button=1
07-11 20:54:58.655+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:58.655+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:58.655+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:58.665+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:58.670+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:58.680+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:58.680+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:58.690+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:58.690+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:58.700+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:58.700+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:58.710+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] mouse move
07-11 20:54:58.710+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437fe910 : elm_genlist] hold(0), freeze(0)
07-11 20:54:58.725+0800 E/EFL     ( 6651): ecore_x<6651> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5282694 button=1
07-11 20:54:59.055+0800 I/efl-extension( 6651): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 20:54:59.055+0800 I/efl-extension( 6651): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x43890cf8, elm_image, _activated_obj : 0x445074b8, activated : 1
07-11 20:54:59.055+0800 I/efl-extension( 6651): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-11 20:54:59.080+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447bfb10 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-11 20:54:59.080+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447bfb10 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-11 20:54:59.100+0800 E/EFL     ( 6651): elementary<6651> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 20:54:59.110+0800 E/EFL     ( 6651): elementary<6651> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x447f7120) will be pushed
07-11 20:54:59.110+0800 I/efl-extension( 6651): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44da3440]'s widget[0x44d99438] to layout widget[0x447f7120]
07-11 20:54:59.110+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447bfb10 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 20:54:59.110+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447bfb10 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 20:54:59.115+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447bfb10 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 20:54:59.115+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447bfb10 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 20:54:59.115+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447bfb10 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 20:54:59.115+0800 E/EFL     ( 6651): elementary<6651> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447bfb10 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 20:54:59.115+0800 I/efl-extension( 6651): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 20:54:59.140+0800 E/EFL     ( 6651): elementary<6651> elc_naviframe.c:2796 _push_transition_cb() item(0x447f7120) will transition
07-11 20:54:59.560+0800 E/EFL     ( 6651): elementary<6651> elc_naviframe.c:1193 _on_item_push_finished() item(0x44507920) transition finished
07-11 20:54:59.560+0800 E/EFL     ( 6651): elementary<6651> elc_naviframe.c:1218 _on_item_show_finished() item(0x447f7120) transition finished
07-11 20:55:01.690+0800 W/SHealthService( 1108): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
07-11 20:55:02.450+0800 E/EFL     ( 6651): ecore_x<6651> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5286416 button=1
07-11 20:55:02.515+0800 E/EFL     ( 6651): ecore_x<6651> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5286484 button=1
07-11 20:55:02.515+0800 E/EFL     ( 6651): elementary<6651> elm_widget.c:4382 elm_widget_type_check() Passing Object: 0x447bf998 in function: elm_naviframe_item_pop, of type: 'rectangle' when expecting type: 'elm_naviframe'
07-11 20:55:12.390+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-11 20:55:16.115+0800 E/RESOURCED(  630): block-monitor.c: block_logging(123) > pid 6651(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/2017-07-11-20--55-acc.txt
07-11 20:55:16.125+0800 E/RESOURCED(  630): block-monitor.c: block_logging(123) > pid 6651(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/2017-07-11-20--55-gyr.txt
07-11 20:55:16.705+0800 W/CRASH_MANAGER( 6801): worker.c: worker_job(1205) > 110665173656e149977771
