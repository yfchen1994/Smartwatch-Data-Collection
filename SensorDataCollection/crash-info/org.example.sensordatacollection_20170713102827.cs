S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 16915
Date: 2017-07-13 10:28:27+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 16915, uid 5000)

Register Information
r0   = 0xbe81232d, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x44d778a0, r5   = 0x44d58080
r6   = 0x44d53158, r7   = 0xbe812010
r8   = 0x00000000, r9   = 0x44d7b478
r10  = 0x44d7e4b0, fp   = 0x00000001
ip   = 0x414d1d74, sp   = 0xbe811ff8
lr   = 0x414c0109, pc   = 0x404f2cb8
cpsr = 0x80000010

Memory Information
MemTotal:   491132 KB
MemFree:     16840 KB
Buffers:      6920 KB
Cached:     127984 KB
VmPeak:      97104 KB
VmSize:      96084 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23700 KB
VmRSS:       23700 KB
VmData:      19008 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25500 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16915 TID = 16915
16915 16999 

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
43c7f000 4447e000 rw-p [stack:16999]
4447e000 4447f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44499000 4449a000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444a5000 444aa000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
444b8000 444c0000 r-xp /usr/lib/libfeedback.so.0.1.4
444c2000 444c3000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
444cb000 444cd000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
444d5000 444e0000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
444e8000 444ef000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44acd000 44ae5000 r-xp /usr/lib/libmmfsound.so.0.1.0
44af6000 44afa000 r-xp /usr/lib/libmmfsession.so.0.0.0
44b03000 44b0e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44b1b000 44b1f000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44b27000 44b3d000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44b45000 44ba6000 r-xp /usr/lib/libasound.so.2.0.0
44bb0000 44bb3000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44bbb000 44bf3000 r-xp /usr/lib/libpulse.so.0.16.2
44bf4000 44bf7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44bff000 44c47000 r-xp /usr/lib/libmdm.so.1.2.62
44c48000 44c4b000 r-xp /usr/lib/libtinycompress.so.0.0.0
44c53000 44c58000 r-xp /usr/lib/libjson.so.0.0.1
44c60000 44ca9000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44cb2000 44cf9000 r-xp /usr/lib/libsndfile.so.1.0.26
44d05000 44d14000 r-xp /usr/lib/libmdm-common.so.1.1.22
44d1d000 44d3f000 r-xp /usr/lib/libvorbis.so.0.4.3
44d47000 44d4b000 r-xp /usr/lib/libogg.so.0.7.1
44e53000 44e63000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
be7f2000 be813000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16915)
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
imeTick(616) > 
07-13 10:28:11.671+0800 E/PKGMGR_SERVER(16904): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-13 10:28:11.741+0800 E/rpm-installer(16905): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-13 10:28:11.741+0800 E/rpm-installer(16905): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-13 10:28:11.741+0800 E/rpm-installer(16905): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-13 10:28:11.791+0800 E/PKGMGR_SERVER(16904): pkgmgr-server.c: sighandler(486) > child NORMAL exit [16905]
07-13 10:28:11.796+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:11.796+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:11.996+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:11.996+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:12.046+0800 I/MALI    (16917): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-13 10:28:12.046+0800 E/MALI    (16917): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-13 10:28:12.056+0800 I/AUL     (16927): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-13 10:28:12.071+0800 I/AUL     (16927): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-13 10:28:12.071+0800 E/AUL     (16927): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-13 10:28:12.071+0800 E/AUL     (16927): aul_path.c: __get_path(169) > root_path is NULL!
07-13 10:28:12.201+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:12.201+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:12.401+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:12.401+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:12.601+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:12.601+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:12.806+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:12.806+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:13.006+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:13.006+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:13.201+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:13.201+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:13.411+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:13.411+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:13.601+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:13.601+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:13.671+0800 E/PKGMGR_SERVER(16904): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-13 10:28:13.671+0800 E/PKGMGR_SERVER(16904): pkgmgr-server.c: main(2296) > package manager server terminated.
07-13 10:28:13.796+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:13.796+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:14.001+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:14.001+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:14.211+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:14.211+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:14.406+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:14.406+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:14.611+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:14.611+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:14.801+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:14.801+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:14.996+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:14.996+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:15.196+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:15.196+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:15.406+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:15.406+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:15.606+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:15.606+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:15.796+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:15.796+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:15.991+0800 W/AUL     (16986): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-13 10:28:15.996+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 0
07-13 10:28:16.001+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:16.001+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:16.021+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-13 10:28:16.041+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-13 10:28:16.041+0800 E/AUL_AMD (  520): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-13 10:28:16.041+0800 W/AUL_AMD (  520): amd_launch.c: _start_app(1782) > caller pid : 16986
07-13 10:28:16.066+0800 W/AUL_AMD (  520): amd_launch.c: _start_app(2218) > pad pid(-5)
07-13 10:28:16.071+0800 W/AUL_PAD ( 1314): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-13 10:28:16.071+0800 W/AUL_PAD ( 1314): launchpad.c: __send_result_to_caller(272) > Check app launching
07-13 10:28:16.076+0800 W/AUL_PAD (16915): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-13 10:28:16.076+0800 W/AUL_PAD (16915): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-13 10:28:16.076+0800 W/AUL_PAD (16915): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-13 10:28:16.076+0800 W/AUL_PAD (16915): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-13 10:28:16.081+0800 E/RESOURCED(  605): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-13 10:28:16.141+0800 I/efl-extension(16915): efl_extension.c: eext_mod_init(40) > Init
07-13 10:28:16.146+0800 I/UXT     (16915): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-13 10:28:16.161+0800 W/AUL_PAD (16915): launchpad_loader.c: main(690) > [candidate] dlsym
07-13 10:28:16.161+0800 W/AUL_PAD (16915): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-13 10:28:16.161+0800 I/CAPI_APPFW_APPLICATION(16915): app_main.c: ui_app_main(704) > app_efl_main
07-13 10:28:16.166+0800 I/CAPI_APPFW_APPLICATION(16915): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-13 10:28:16.171+0800 W/AUL     (  520): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(16915) type(uiapp) bg(0)
07-13 10:28:16.171+0800 W/AUL     (16986): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16915)
07-13 10:28:16.171+0800 W/AUL_AMD (  520): amd_status.c: __socket_monitor_cb(1277) > (16915) was created
07-13 10:28:16.196+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:16.196+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:16.211+0800 W/STARTER (  741): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16915]
07-13 10:28:16.371+0800 I/efl-extension(16915): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-13 10:28:16.371+0800 I/efl-extension(16915): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-13 10:28:16.371+0800 I/efl-extension(16915): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-13 10:28:16.371+0800 I/efl-extension(16915): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-13 10:28:16.371+0800 I/efl-extension(16915): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4187e060, elm_image, _activated_obj : 0x0, activated : 1
07-13 10:28:16.371+0800 E/EFL     (16915): elementary<16915> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-13 10:28:16.386+0800 E/EFL     (16915): elementary<16915> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4187e4c8) will be pushed
07-13 10:28:16.386+0800 I/efl-extension(16915): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x446076c0]'s widget[0x4187f958] to layout widget[0x4187e4c8]
07-13 10:28:16.386+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:28:16.386+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-13 10:28:16.386+0800 I/efl-extension(16915): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-13 10:28:16.396+0800 I/APP_CORE(16915): appcore-efl.c: __do_app(453) > [APP 16915] Event: RESET State: CREATED
07-13 10:28:16.396+0800 I/CAPI_APPFW_APPLICATION(16915): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-13 10:28:16.396+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:16.396+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:16.411+0800 I/APP_CORE(16915): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-13 10:28:16.416+0800 I/APP_CORE(16915): appcore-efl.c: __do_app(524) > [APP 16915] Initial Launching, call the resume_cb
07-13 10:28:16.416+0800 I/CAPI_APPFW_APPLICATION(16915): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-13 10:28:16.426+0800 W/APP_CORE(16915): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1a00002
07-13 10:28:16.441+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:28:16.441+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-13 10:28:16.441+0800 W/W_HOME  (  806): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-13 10:28:16.441+0800 W/W_HOME  (  806): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-13 10:28:16.441+0800 W/W_HOME  (  806): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-13 10:28:16.441+0800 W/W_INDICATOR(  742): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-13 10:28:16.441+0800 W/W_INDICATOR(  742): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-13 10:28:16.446+0800 W/W_HOME  (  806): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-13 10:28:16.446+0800 W/W_HOME  (  806): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-13 10:28:16.496+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-13 10:28:16.496+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-13 10:28:16.596+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:28:16.596+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:28:16.606+0800 W/W_HOME  (  806): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-13 10:28:16.606+0800 W/W_HOME  (  806): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-13 10:28:16.606+0800 W/W_HOME  (  806): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-13 10:28:16.606+0800 W/W_HOME  (  806): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-13 10:28:16.606+0800 W/W_HOME  (  806): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-13 10:28:16.616+0800 W/AUL     (  520): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(806) status(bg) type(uiapp)
07-13 10:28:16.616+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[806] goes to (4)
07-13 10:28:16.616+0800 E/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 806)'s state(4)
07-13 10:28:16.626+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[16915] goes to (3)
07-13 10:28:16.626+0800 W/AUL_AMD (  520): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-13 10:28:16.626+0800 W/AUL_AMD (  520): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-13 10:28:16.626+0800 W/AUL     (  520): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(16915) status(fg) type(uiapp)
07-13 10:28:16.646+0800 I/APP_CORE(  806): appcore-efl.c: __do_app(453) > [APP 806] Event: PAUSE State: RUNNING
07-13 10:28:16.646+0800 I/CAPI_APPFW_APPLICATION(  806): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-13 10:28:16.646+0800 W/W_HOME  (  806): main.c: _appcore_pause_cb(487) > appcore pause
07-13 10:28:16.646+0800 W/W_HOME  (  806): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-13 10:28:16.646+0800 W/W_HOME  (  806): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-13 10:28:16.646+0800 W/W_HOME  (  806): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-13 10:28:16.646+0800 W/W_HOME  (  806): main.c: home_pause(546) > clock/widget paused
07-13 10:28:16.646+0800 W/W_HOME  (  806): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-13 10:28:16.646+0800 W/W_INDICATOR(  742): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-13 10:28:16.646+0800 W/W_INDICATOR(  742): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-13 10:28:16.646+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-13 10:28:16.651+0800 E/CAPI_APPFW_APP_CONTROL( 1010): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-13 10:28:16.651+0800 W/MUSIC_CONTROL_SERVICE( 1010): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1010]   [com.samsung.w-home]register msg port [false][0m
07-13 10:28:16.661+0800 I/wnotib  (  806): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-13 10:28:16.661+0800 E/wnotib  (  806): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-13 10:28:16.661+0800 W/wnotib  (  806): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [1], notiboard card appending count [2].
07-13 10:28:16.671+0800 W/WATCH_CORE(  929): appcore-watch.c: __widget_pause(1113) > widget_pause
07-13 10:28:16.671+0800 W/AUL     (  929): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(929) status(bg) type(watchapp)
07-13 10:28:16.671+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppPause(589) > 
07-13 10:28:16.696+0800 I/APP_CORE(16915): appcore-efl.c: __do_app(453) > [APP 16915] Event: RESUME State: RUNNING
07-13 10:28:16.991+0800 E/AUL     (  520): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-13 10:28:17.161+0800 I/APP_CORE(  806): appcore-efl.c: __do_app(453) > [APP 806] Event: MEM_FLUSH State: PAUSED
07-13 10:28:17.381+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-13 10:28:17.391+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16915
07-13 10:28:17.396+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-13 10:28:17.406+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-13 10:28:17.411+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16915
07-13 10:28:17.416+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-13 10:28:17.626+0800 I/AUL_PAD (16988): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-13 10:28:18.506+0800 E/EFL     (16915): ecore_x<16915> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51382796 button=1
07-13 10:28:18.506+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-13 10:28:18.506+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-13 10:28:18.506+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-13 10:28:18.536+0800 E/EFL     (16915): ecore_x<16915> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=51382843 button=1
07-13 10:28:18.826+0800 E/EFL     (16915): elementary<16915> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x447b1c08 into part 'elm.swallow.content'
07-13 10:28:18.896+0800 E/EFL     (16915): edje<16915> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:28:18.916+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] mx(30), my(40), minx(0), miny(0), px(0), py(0)
07-13 10:28:18.916+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] cw(30), ch(40), pw(0), ph(0)
07-13 10:28:18.926+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] mx(4), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:28:18.926+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] cw(4), ch(40), pw(0), ph(40)
07-13 10:28:18.926+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] mx(4), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:28:18.926+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] cw(4), ch(40), pw(0), ph(40)
07-13 10:28:18.926+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b1c08 : elm_scroller] mx(0), my(50), minx(0), miny(0), px(0), py(0)
07-13 10:28:18.926+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b1c08 : elm_scroller] cw(0), ch(50), pw(0), ph(0)
07-13 10:28:18.946+0800 E/EFL     (16915): elementary<16915> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-13 10:28:18.956+0800 E/EFL     (16915): elementary<16915> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44d83bc0) will be pushed
07-13 10:28:18.956+0800 I/efl-extension(16915): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44d9bcc8]'s widget[0x44d86078] to layout widget[0x44d83bc0]
07-13 10:28:18.961+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:28:18.961+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:28:18.961+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:28:18.961+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:28:18.961+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b1c08 : elm_scroller] mx(360), my(360), minx(0), miny(0), px(0), py(0)
07-13 10:28:18.961+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b1c08 : elm_scroller] cw(360), ch(360), pw(0), ph(0)
07-13 10:28:18.961+0800 I/efl-extension(16915): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-13 10:28:18.971+0800 E/EFL     (16915): edje<16915> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:28:19.011+0800 E/EFL     (16915): elementary<16915> elc_naviframe.c:2796 _push_transition_cb() item(0x44d83bc0) will transition
07-13 10:28:19.421+0800 E/EFL     (16915): elementary<16915> elc_naviframe.c:1193 _on_item_push_finished() item(0x4187e4c8) transition finished
07-13 10:28:19.426+0800 E/EFL     (16915): elementary<16915> elc_naviframe.c:1218 _on_item_show_finished() item(0x44d83bc0) transition finished
07-13 10:28:19.441+0800 I/ISE_MULTI(  803): isemain.cpp: slot_set_return_key_disable(1252) > [0;36m[hidden state:true] disabled=0[0m
07-13 10:28:19.441+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
07-13 10:28:19.441+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
07-13 10:28:19.441+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
07-13 10:28:19.441+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
07-13 10:28:19.441+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1a00002 FAILED!
07-13 10:28:19.441+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1a00002 FAILED!
07-13 10:28:19.486+0800 I/ISE_MULTI(  803): isemain.cpp: slot_set_caps_mode(1113) > [0;36m[hidden state:true] mode=1[0m
07-13 10:28:19.516+0800 E/EFL     (  462): ecore_x<462> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1a00002 time=51383775
07-13 10:28:19.551+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:28:19.571+0800 E/EFL     (16915): ecore_x<16915> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=51383775
07-13 10:28:19.571+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=51383775
07-13 10:28:19.606+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:28:19.606+0800 I/ISE_MULTI(  803): ise.cpp: ise_show(2316) > [0;36m--------BEFORE set is_candidate_on-----------[0m
07-13 10:28:19.606+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:28:19.606+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(335) > [0;36m----------START----------[0m
07-13 10:28:19.606+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(347) > [0;36m-------INPUT_MODE_HANDWRITING--------[0m
07-13 10:28:19.606+0800 E/ISE_MULTI(  803): ise-rotary-event-listener.cpp: rotary_input_init(119) > [0;31mrotary_input_init[0m
07-13 10:28:19.616+0800 W/SWIFTKEY(  668): swiftkey_logger.cpp: reportError(44) > [0;33mSKLogger [ File Not Found : Could not read keypress model file at "/opt/usr/share/scim/swiftkey/lang/zh_CN/keyModel_qwerty_port.json" ][0m
07-13 10:28:19.616+0800 W/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Load_keymodel(2368) > [0;33mfail to set the keypress model to /opt/usr/share/scim/swiftkey/lang/zh_CN/keyModel_qwerty_port.json[0m
07-13 10:28:19.626+0800 I/ISE_MULTI(  803): ise.cpp: ise_show(2374) > [0;36m--------------------[0m
07-13 10:28:19.626+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(986) > [0;36m-----candidate_show-----[0m
07-13 10:28:19.626+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1008) > [0;36mcandidate_show:is_chinese = 1[0m
07-13 10:28:19.626+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1034) > [0;36m-----END-----[0m
07-13 10:28:19.671+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:28:19.706+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:28:19.721+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_hide(1039) > [0;36mcandidate_hide[0m
07-13 10:28:19.836+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:28:19.951+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:19.951+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:20.011+0800 E/AUL_AMD (  520): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
07-13 10:28:20.011+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[803] goes to (3)
07-13 10:28:20.031+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [280x300]
07-13 10:28:20.061+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:20.061+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:20.061+0800 E/ISE_MULTI(  803): ise-ui.cpp: indicator_popup_show_cb(1533) > [0;31mindicator_popup_show_cb[0m
07-13 10:28:20.261+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:20.261+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:20.261+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:28:20.261+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:28:20.271+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51384599 button=1
07-13 10:28:20.306+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x22]
07-13 10:28:20.401+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:28:20.406+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:28:20.431+0800 E/EFL     (16915): edje<16915> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:28:20.431+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b1c08 : elm_scroller] mx(360), my(70), minx(0), miny(0), px(0), py(0)
07-13 10:28:20.431+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b1c08 : elm_scroller] cw(360), ch(70), pw(0), ph(0)
07-13 10:28:20.431+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:28:20.431+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:28:20.481+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=0[0m
07-13 10:28:20.496+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [280x300] -> [360x360]
07-13 10:28:20.521+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:20.521+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:20.526+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:20.526+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:20.526+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:20.526+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:20.531+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:20.531+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:20.536+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:20.536+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:20.541+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:20.541+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:20.546+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:20.546+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:20.546+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:28:20.546+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:28:20.551+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:20.551+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:20.551+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:28:20.551+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:28:21.161+0800 E/ISE_HWR (  803): handwriting.cpp: efl_ise_recog_timeout(213) > [0;31mEND[0m
07-13 10:28:21.196+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [360x360] -> [280x300]
07-13 10:28:21.346+0800 E/EFL     (  462): ecore_x<462> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2800059 time=51385534
07-13 10:28:21.346+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=51385534
07-13 10:28:21.661+0800 I/APP_CORE(  806): appcore-efl.c: __do_app(453) > [APP 806] Event: MEM_FLUSH State: PAUSED
07-13 10:28:21.691+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:28:21.691+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:28:21.706+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5480) > [0;36mSK_CMD_HWR_CANDIDATE_STRING[0m
07-13 10:28:21.706+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(0) = .[0m
07-13 10:28:21.706+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(1) = 0[0m
07-13 10:28:21.706+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(2) = ÿ[0m
07-13 10:28:21.706+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(3) = 0[0m
07-13 10:28:21.706+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(4) = o[0m
07-13 10:28:21.706+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5494) > [0;36mbefore update_lookup_table[0m
07-13 10:28:21.706+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:21.706+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:21.721+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 0[0m
07-13 10:28:22.481+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51386808 button=1
07-13 10:28:22.646+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [280x300] -> [360x360]
07-13 10:28:22.686+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51387011 button=1
07-13 10:28:22.966+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:28:22.966+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:28:22.996+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5480) > [0;36mSK_CMD_HWR_CANDIDATE_STRING[0m
07-13 10:28:22.996+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(0) = ŒN[0m
07-13 10:28:22.996+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(1) = 2[0m
07-13 10:28:22.996+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(2) = 	N[0m
07-13 10:28:22.996+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(3) = i[0m
07-13 10:28:22.996+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(4) = KN[0m
07-13 10:28:22.996+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5494) > [0;36mbefore update_lookup_table[0m
07-13 10:28:23.021+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:23.021+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:23.026+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 0[0m
07-13 10:28:23.191+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51387523 button=1
07-13 10:28:23.436+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: focus_in_timer(381) > [0;36mfocus_in_timer[0m
07-13 10:28:23.436+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: reload_config_thread(256) > [0;36mg_prediction_setting_value = [1], arg = [1], try--1[0m
07-13 10:28:23.441+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:28:23.441+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:28:23.446+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5480) > [0;36mSK_CMD_HWR_CANDIDATE_STRING[0m
07-13 10:28:23.446+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(0) = i[0m
07-13 10:28:23.446+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(1) = úQ[0m
07-13 10:28:23.446+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(2) = Øš[0m
07-13 10:28:23.446+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(3) = i[0m
07-13 10:28:23.446+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(4) = ^[0m
07-13 10:28:23.446+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5494) > [0;36mbefore update_lookup_table[0m
07-13 10:28:23.451+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:23.451+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:23.501+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 0[0m
07-13 10:28:24.741+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Load_lang(1045) > [0;36mSuccessfully loaded DB : en_US[0m
07-13 10:28:24.766+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:28:24.766+0800 E/EFL     (16915): elementary<16915> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447b3968 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:28:24.771+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5480) > [0;36mSK_CMD_HWR_CANDIDATE_STRING[0m
07-13 10:28:24.771+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(0) = ó—[0m
07-13 10:28:24.771+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(1) = w[0m
07-13 10:28:24.771+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(2) = ó—[0m
07-13 10:28:24.771+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(3) = Øš[0m
07-13 10:28:24.771+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5490) > [0;36mise_data.at(4) = þf[0m
07-13 10:28:24.771+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: process_helper_event(5494) > [0;36mbefore update_lookup_table[0m
07-13 10:28:24.776+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:28:24.776+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:28:24.781+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 0[0m
07-13 10:28:25.156+0800 E/ISE_HWR (  803): handwriting.cpp: efl_ise_recog_timeout(213) > [0;31mEND[0m
07-13 10:28:25.176+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [360x360] -> [280x300]
07-13 10:28:27.276+0800 E/EFL     (16915): ecore_x<16915> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51391601 button=1
07-13 10:28:27.276+0800 E/EFL     (16915): ecore_x<16915> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=51391604 button=1
07-13 10:28:27.286+0800 I/ISE_MULTI(  803): isemain.cpp: slot_reset_ise_input_context(1372) > [0;36m[hidden state:false][0m
07-13 10:28:27.316+0800 E/ISE_HWR (  803): handwriting.cpp: __hwr_result_notification_callback(857) > [0;31m============iscommited == 1[0m
07-13 10:28:27.651+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1a00002 FAILED!
07-13 10:28:27.656+0800 W/CRASH_MANAGER(17018): worker.c: worker_job(1205) > 111691573656e149991290
