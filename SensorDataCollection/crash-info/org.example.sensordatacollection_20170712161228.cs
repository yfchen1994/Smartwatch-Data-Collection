S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 13088
Date: 2017-07-12 16:12:28+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 13088, uid 5000)

Register Information
r0   = 0xbed8132c, r1   = 0x646d696d
r2   = 0x5a6aa9be, r3   = 0xbed8143d
r4   = 0x403119b8, r5   = 0x403119b8
r6   = 0x4031116c, r7   = 0xbed81130
r8   = 0x403119b8, r9   = 0x41b9bcf8
r10  = 0x4031fb10, fp   = 0x00000000
ip   = 0x404f2cf4, sp   = 0xbed80ef8
lr   = 0x413c0bb9, pc   = 0x404f2cfc
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:      3984 KB
Buffers:     29812 KB
Cached:     137208 KB
VmPeak:      84212 KB
VmSize:      82176 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24080 KB
VmRSS:       24080 KB
VmData:      18640 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13088 TID = 13088
13088 13215 

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
41abb000 41ac3000 r-xp /usr/lib/libdrm.so.2.4.0
41acb000 41acd000 r-xp /usr/lib/libdri2.so.0.0.0
41ad5000 41adb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41ae3000 41ae8000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41af0000 41b09000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41b11000 41b32000 r-xp /usr/lib/libexif.so.12.3.3
41b45000 41b47000 r-xp /usr/lib/libttrace.so.1.1
41b4f000 41b54000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41b61000 41b63000 rw-p [heap]
41b63000 41c97000 rw-p [heap]
41c97000 41d9d000 r-xp /usr/lib/libicuuc.so.57.1
4364c000 43652000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4365b000 43663000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4366b000 4368d000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43696000 4369d000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436a6000 436a8000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436b0000 436b7000 r-xp /usr/lib/libminizip.so.1.0.0
436bf000 436cc000 r-xp /usr/lib/libail.so.0.1.0
436d5000 436db000 r-xp /usr/lib/libproc-stat.so.0.2.96
436e3000 436e4000 r-xp /usr/lib/libresponse.so.0.2.96
436ec000 436f1000 r-xp /usr/lib/libsystem.so.0.0.0
436fb000 437c5000 r-xp /usr/lib/libCOREGL.so.4.0
43c6a000 43c75000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c7e000 43c83000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c8b000 43ca2000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43caf000 43cb1000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43cba000 444b9000 rw-p [stack:13215]
444b9000 444ba000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444d0000 444d1000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444ef000 444f7000 r-xp /usr/lib/libfeedback.so.0.1.4
44acb000 44acc000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44ad4000 44ad6000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44ade000 44ae9000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44af1000 44af8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44b00000 44b18000 r-xp /usr/lib/libmmfsound.so.0.1.0
44b29000 44b2d000 r-xp /usr/lib/libmmfsession.so.0.0.0
44b36000 44b41000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44b4e000 44b52000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44b5a000 44b70000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44b78000 44bd9000 r-xp /usr/lib/libasound.so.2.0.0
44be3000 44be6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44bee000 44c26000 r-xp /usr/lib/libpulse.so.0.16.2
44c27000 44c2a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44c32000 44c7a000 r-xp /usr/lib/libmdm.so.1.2.62
44c7b000 44c7e000 r-xp /usr/lib/libtinycompress.so.0.0.0
44c86000 44c8b000 r-xp /usr/lib/libjson.so.0.0.1
44c93000 44cdc000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44ce5000 44d2c000 r-xp /usr/lib/libsndfile.so.1.0.26
44d38000 44d47000 r-xp /usr/lib/libmdm-common.so.1.1.22
44d50000 44d72000 r-xp /usr/lib/libvorbis.so.0.4.3
44d7a000 44d7e000 r-xp /usr/lib/libogg.so.0.7.1
bed61000 bed82000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13088)
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
y_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 16:12:14.901+0800 I/AUL     (13090): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 16:12:14.901+0800 E/AUL     (13090): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 16:12:14.906+0800 E/AUL     (13090): aul_path.c: __get_path(169) > root_path is NULL!
07-12 16:12:14.916+0800 I/AUL     (13090): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 16:12:14.931+0800 I/AUL     (13090): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 16:12:14.931+0800 E/AUL     (13090): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 16:12:14.931+0800 E/AUL     (13090): aul_path.c: __get_path(169) > root_path is NULL!
07-12 16:12:14.946+0800 I/AUL     (13090): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 16:12:14.956+0800 I/AUL     (13090): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 16:12:14.956+0800 E/AUL     (13090): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 16:12:14.961+0800 E/AUL     (13090): aul_path.c: __get_path(169) > root_path is NULL!
07-12 16:12:14.986+0800 I/UXT     (13090): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-12 16:12:15.116+0800 E/MALI    (13090): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-12 16:12:15.116+0800 E/MALI    (13090): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-12 16:12:15.116+0800 E/MALI    (13090): [gpu-ddk] devel/graphics_drv/r4p0
07-12 16:12:15.116+0800 E/MALI    (13090): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-12 16:12:15.116+0800 E/MALI    (13090): [coregl] devel/graphics_engine/master
07-12 16:12:15.116+0800 E/MALI    (13090): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-12 16:12:15.116+0800 E/MALI    (13090): 
07-12 16:12:15.691+0800 E/rpm-installer(13078): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-12 16:12:15.691+0800 E/rpm-installer(13078): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-12 16:12:15.691+0800 E/rpm-installer(13078): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-12 16:12:15.711+0800 E/PKGMGR_SERVER(13024): pkgmgr-server.c: sighandler(486) > child NORMAL exit [13078]
07-12 16:12:15.791+0800 E/RESOURCED(  600): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/13078/oom_score_adj failed
07-12 16:12:15.791+0800 E/RESOURCED(  600): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 13078
07-12 16:12:16.026+0800 I/MALI    (13090): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-12 16:12:16.036+0800 E/MALI    (13090): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-12 16:12:16.041+0800 I/AUL     (13099): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-12 16:12:16.056+0800 I/AUL     (13099): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 16:12:16.056+0800 E/AUL     (13099): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 16:12:16.056+0800 E/AUL     (13099): aul_path.c: __get_path(169) > root_path is NULL!
07-12 16:12:16.566+0800 E/PKGMGR_SERVER(13024): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-12 16:12:16.566+0800 E/PKGMGR_SERVER(13024): pkgmgr-server.c: main(2296) > package manager server terminated.
07-12 16:12:20.211+0800 W/AUL     (13185): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-12 16:12:20.216+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 0
07-12 16:12:20.246+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-12 16:12:20.266+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-12 16:12:20.266+0800 E/AUL_AMD (  524): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-12 16:12:20.266+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(1782) > caller pid : 13185
07-12 16:12:20.281+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(2218) > pad pid(-5)
07-12 16:12:20.286+0800 W/AUL_PAD ( 1308): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-12 16:12:20.286+0800 W/AUL_PAD ( 1308): launchpad.c: __send_result_to_caller(272) > Check app launching
07-12 16:12:20.286+0800 E/RESOURCED(  600): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-12 16:12:20.286+0800 W/AUL_PAD (13088): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-12 16:12:20.291+0800 W/AUL_PAD (13088): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-12 16:12:20.291+0800 W/AUL_PAD (13088): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-12 16:12:20.291+0800 W/AUL_PAD (13088): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-12 16:12:20.356+0800 I/efl-extension(13088): efl_extension.c: eext_mod_init(40) > Init
07-12 16:12:20.361+0800 I/UXT     (13088): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-12 16:12:20.381+0800 W/AUL_PAD (13088): launchpad_loader.c: main(690) > [candidate] dlsym
07-12 16:12:20.381+0800 W/AUL_PAD (13088): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-12 16:12:20.381+0800 I/CAPI_APPFW_APPLICATION(13088): app_main.c: ui_app_main(704) > app_efl_main
07-12 16:12:20.386+0800 I/CAPI_APPFW_APPLICATION(13088): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-12 16:12:20.486+0800 W/AUL     (  524): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(13088) type(uiapp) bg(0)
07-12 16:12:20.486+0800 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (13088) was created
07-12 16:12:20.486+0800 W/AUL     (13185): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13088)
07-12 16:12:20.486+0800 W/STARTER (  754): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [13088]
07-12 16:12:20.576+0800 I/efl-extension(13088): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 16:12:20.576+0800 I/efl-extension(13088): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-12 16:12:20.576+0800 I/efl-extension(13088): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-12 16:12:20.581+0800 I/efl-extension(13088): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-12 16:12:20.581+0800 I/efl-extension(13088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445074b8, elm_image, _activated_obj : 0x0, activated : 1
07-12 16:12:20.581+0800 E/EFL     (13088): elementary<13088> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 16:12:20.586+0800 E/EFL     (13088): elementary<13088> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44507920) will be pushed
07-12 16:12:20.586+0800 I/efl-extension(13088): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x437e8de0]'s widget[0x44508db0] to layout widget[0x44507920]
07-12 16:12:20.591+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 16:12:20.591+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-12 16:12:20.591+0800 I/efl-extension(13088): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 16:12:20.601+0800 I/APP_CORE(13088): appcore-efl.c: __do_app(453) > [APP 13088] Event: RESET State: CREATED
07-12 16:12:20.601+0800 I/CAPI_APPFW_APPLICATION(13088): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-12 16:12:20.621+0800 I/APP_CORE(13088): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-12 16:12:20.621+0800 I/APP_CORE(13088): appcore-efl.c: __do_app(524) > [APP 13088] Initial Launching, call the resume_cb
07-12 16:12:20.621+0800 I/CAPI_APPFW_APPLICATION(13088): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-12 16:12:20.636+0800 W/W_HOME  (  811): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-12 16:12:20.636+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:12:20.636+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:12:20.641+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 16:12:20.641+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:12:20.641+0800 W/W_HOME  (  811): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-12 16:12:20.641+0800 W/W_HOME  (  811): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-12 16:12:20.641+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 16:12:20.676+0800 W/APP_CORE(13088): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1600002
07-12 16:12:20.681+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 16:12:20.681+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-12 16:12:20.716+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-12 16:12:20.716+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-12 16:12:20.801+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-12 16:12:20.801+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-12 16:12:20.801+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:12:20.801+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:12:20.801+0800 W/W_HOME  (  811): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-12 16:12:20.806+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: PAUSE State: RUNNING
07-12 16:12:20.806+0800 I/CAPI_APPFW_APPLICATION(  811): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-12 16:12:20.806+0800 W/W_HOME  (  811): main.c: _appcore_pause_cb(487) > appcore pause
07-12 16:12:20.806+0800 W/W_HOME  (  811): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-12 16:12:20.806+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:12:20.806+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:12:20.806+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 16:12:20.806+0800 W/W_HOME  (  811): rotary.c: rotary_deattach(156) > rotary_deattach:0x474c2038
07-12 16:12:20.806+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-12 16:12:20.806+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x474c2038, elm_layout, func : 0x4005653d
07-12 16:12:20.806+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-12 16:12:20.806+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-12 16:12:20.806+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-12 16:12:20.806+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e39b0, elm_box, _activated_obj : 0x474c2038, activated : 1
07-12 16:12:20.806+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 16:12:20.806+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 16:12:20.806+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-12 16:12:20.811+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(811) status(bg) type(uiapp)
07-12 16:12:20.811+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[811] goes to (4)
07-12 16:12:20.811+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 811)'s state(4)
07-12 16:12:20.821+0800 W/W_HOME  (  811): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-12 16:12:20.826+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 16:12:20.831+0800 E/CAPI_APPFW_APP_CONTROL( 1005): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-12 16:12:20.831+0800 W/MUSIC_CONTROL_SERVICE( 1005): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1005]   [com.samsung.w-home]register msg port [false][0m
07-12 16:12:20.831+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 16:12:20.841+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9272
07-12 16:12:20.846+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-12 16:12:20.846+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 16:12:20.851+0800 W/wnotib  (  811): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [1], notiboard card appending count [1].
07-12 16:12:20.856+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[13088] goes to (3)
07-12 16:12:20.856+0800 W/AUL_AMD (  524): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-12 16:12:20.856+0800 W/AUL_AMD (  524): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-12 16:12:20.856+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(13088) status(fg) type(uiapp)
07-12 16:12:20.866+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 16:12:20.871+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 16:12:20.876+0800 I/APP_CORE(13088): appcore-efl.c: __do_app(453) > [APP 13088] Event: RESUME State: RUNNING
07-12 16:12:20.886+0800 W/APPS    (  811): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-12 16:12:21.201+0800 E/AUL     (  524): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-12 16:12:21.346+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 16:12:21.761+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 16:12:21.781+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13088
07-12 16:12:21.786+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 16:12:21.801+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 16:12:21.816+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13088
07-12 16:12:21.821+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 16:12:22.076+0800 I/AUL_PAD (13187): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-12 16:12:22.791+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 16:12:22.801+0800 W/SHealthCommon( 1107): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499817600000.000000[0;m
07-12 16:12:22.881+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-12 16:12:22.891+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 16:12:22.911+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 16:12:23.376+0800 W/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-12 16:12:23.376+0800 I/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-12 16:12:23.386+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 16:12:23.386+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 16:12:23.396+0800 I/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-12 16:12:23.456+0800 E/wnoti-service( 1046): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-12 16:12:23.456+0800 E/wnoti-service( 1046): wnoti-native-client.c: handle_cache_notification(737) > >>
07-12 16:12:23.471+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-12 16:12:23.471+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-12 16:12:23.471+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-12 16:12:23.471+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-12 16:12:23.471+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-12 16:12:23.471+0800 W/WECONN  (  506): <wc_manager_get_bearer_state:988> type : 1
07-12 16:12:23.496+0800 E/ALARM_MANAGER(  506): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(12-7-2017, 16:12:28), repeat(0), interval(0), type(-1073741822)
07-12 16:12:23.496+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [506].
07-12 16:12:23.501+0800 W/SHealthService( 1107): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-12 16:12:23.511+0800 I/efl-extension(  811): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.511+0800 I/efl-extension( 6670): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.511+0800 I/efl-extension(13088): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.511+0800 I/efl-extension(13088): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x445074b8, elm_image, time_stamp : 20669944
07-12 16:12:23.516+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-12 16:12:23.516+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-12 16:12:23.516+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] x(0), y(130)
07-12 16:12:23.516+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x437db910 : elm_genlist] t_in(0.300000), pos_x(0)
07-12 16:12:23.516+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x437db910 : elm_genlist] t_in(0.300000), pos_y(130)
07-12 16:12:23.516+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] time(0.028682)
07-12 16:12:23.516+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-12 16:12:23.516+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] time(0.028682)
07-12 16:12:23.526+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(3)
07-12 16:12:23.541+0800 I/AUL     (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 16:12:23.551+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 15
07-12 16:12:23.561+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] time(0.302615)
07-12 16:12:23.566+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(3)
07-12 16:12:23.566+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] time(0.302615)
07-12 16:12:23.566+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(39)
07-12 16:12:23.566+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 16:12:23.581+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 16:12:23.581+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499847148, Wed Jul 12 16:12:28 2017
07-12 16:12:23.581+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1026269943, next duetime: 1499847148
07-12 16:12:23.581+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1026269943)
07-12 16:12:23.581+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499853548), due_time(1499847148)
07-12 16:12:23.596+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 16:12:23.596+0800 I/efl-extension( 9272): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.601+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] time(0.507201)
07-12 16:12:23.601+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(39)
07-12 16:12:23.601+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] time(0.507201)
07-12 16:12:23.606+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 16:12:23.606+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 08:12:28 (UTC).
07-12 16:12:23.606+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 16:12:23.606+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:12:23.606+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(65)
07-12 16:12:23.611+0800 I/efl-extension(  811): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.611+0800 I/efl-extension( 6670): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.626+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 16:12:23.626+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:12:23.631+0800 I/efl-extension( 9272): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.636+0800 I/efl-extension(13088): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.636+0800 I/efl-extension(13088): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x445074b8, elm_image, time_stamp : 20670041
07-12 16:12:23.636+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] time(0.647251)
07-12 16:12:23.636+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(65)
07-12 16:12:23.636+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] time(0.647251)
07-12 16:12:23.636+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(84)
07-12 16:12:23.636+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:385> }
07-12 16:12:23.636+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:531> }
07-12 16:12:23.636+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(84)
07-12 16:12:23.636+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-12 16:12:23.636+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1910 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] scrollto.x.animator(0x41c6e270)
07-12 16:12:23.636+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1916 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] scrollto.y.animator(0x41c6e3b0)
07-12 16:12:23.636+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x437db910 : elm_genlist] x(0), y(130)
07-12 16:12:23.636+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x437db910 : elm_genlist] t_in(0.300000), pos_x(0)
07-12 16:12:23.636+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x437db910 : elm_genlist] t_in(0.300000), pos_y(130)
07-12 16:12:23.661+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] time(0.154588)
07-12 16:12:23.661+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(84)
07-12 16:12:23.661+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] time(0.154588)
07-12 16:12:23.661+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(91)
07-12 16:12:23.681+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] time(0.282641)
07-12 16:12:23.681+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(91)
07-12 16:12:23.681+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] time(0.282641)
07-12 16:12:23.681+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(97)
07-12 16:12:23.701+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] time(0.398138)
07-12 16:12:23.701+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(97)
07-12 16:12:23.701+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] time(0.398138)
07-12 16:12:23.706+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(102)
07-12 16:12:23.706+0800 I/efl-extension(  811): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.706+0800 I/efl-extension( 6670): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.706+0800 I/efl-extension( 9272): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.726+0800 I/efl-extension(13088): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-12 16:12:23.726+0800 I/efl-extension(13088): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x445074b8, elm_image, time_stamp : 20670142
07-12 16:12:23.921+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] time(0.526423)
07-12 16:12:23.921+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(102)
07-12 16:12:23.921+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] time(0.526423)
07-12 16:12:23.926+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(108)
07-12 16:12:23.956+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] time(0.995293)
07-12 16:12:23.956+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(108)
07-12 16:12:23.956+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] time(0.995293)
07-12 16:12:23.961+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] animation stop!!
07-12 16:12:23.961+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x437db910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-12 16:12:24.381+0800 E/EFL     (13088): ecore_x<13088> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=20670802 button=1
07-12 16:12:24.381+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437db910 : elm_genlist] mouse move
07-12 16:12:24.386+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437db910 : elm_genlist] mouse move
07-12 16:12:24.386+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437db910 : elm_genlist] hold(0), freeze(0)
07-12 16:12:24.411+0800 E/EFL     (13088): ecore_x<13088> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=20670845 button=1
07-12 16:12:24.411+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437db910 : elm_genlist] mouse move
07-12 16:12:24.411+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437db910 : elm_genlist] hold(0), freeze(0)
07-12 16:12:24.456+0800 I/efl-extension(13088): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 16:12:24.456+0800 I/efl-extension(13088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x447fb128, elm_image, _activated_obj : 0x445074b8, activated : 1
07-12 16:12:24.456+0800 I/efl-extension(13088): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 16:12:24.471+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447f93c8 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-12 16:12:24.471+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447f93c8 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-12 16:12:24.491+0800 E/EFL     (13088): elementary<13088> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 16:12:24.496+0800 E/EFL     (13088): elementary<13088> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44818540) will be pushed
07-12 16:12:24.496+0800 I/efl-extension(13088): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44dc7398]'s widget[0x44dc1d78] to layout widget[0x44818540]
07-12 16:12:24.501+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447f93c8 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-12 16:12:24.501+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447f93c8 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-12 16:12:24.501+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447f93c8 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-12 16:12:24.501+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447f93c8 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-12 16:12:24.501+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447f93c8 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-12 16:12:24.501+0800 E/EFL     (13088): elementary<13088> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447f93c8 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-12 16:12:24.501+0800 I/efl-extension(13088): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 16:12:24.526+0800 E/EFL     (13088): elementary<13088> elc_naviframe.c:2796 _push_transition_cb() item(0x44818540) will transition
07-12 16:12:24.961+0800 E/EFL     (13088): elementary<13088> elc_naviframe.c:1193 _on_item_push_finished() item(0x44507920) transition finished
07-12 16:12:24.966+0800 E/EFL     (13088): elementary<13088> elc_naviframe.c:1218 _on_item_show_finished() item(0x44818540) transition finished
07-12 16:12:25.211+0800 E/EFL     (13088): ecore_x<13088> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=20671646 button=1
07-12 16:12:25.271+0800 E/EFL     (13088): ecore_x<13088> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=20671706 button=1
07-12 16:12:25.516+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 16:12:25.546+0800 E/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-12 16:12:25.551+0800 W/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(359) > [1;40;33mOnNotWearingStop[0;m
07-12 16:12:25.626+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 16:12:25.641+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 16:12:25.651+0800 W/SHealthCommon( 1107): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499817600000.000000[0;m
07-12 16:12:25.671+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-12 16:12:25.676+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-12 16:12:25.681+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 16:12:25.696+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 16:12:25.846+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 16:12:26.291+0800 E/EFL     (  397): ecore_x<397> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1600002 time=20671706
07-12 16:12:26.301+0800 E/EFL     (13088): ecore_x<13088> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=20671706
07-12 16:12:26.306+0800 E/EFL     (  397): ecore_x<397> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=20671706
07-12 16:12:28.001+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
07-12 16:12:28.066+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 16:12:28.111+0800 W/AUL     (  518): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(506) type(wakeup)
07-12 16:12:28.116+0800 E/RESOURCED(  600): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 506
07-12 16:12:28.136+0800 E/ALARM_MANAGER(  506): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [1026269943]
07-12 16:12:28.136+0800 W/WECONN  (  506): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
07-12 16:12:28.136+0800 W/WECONN  (  506): <wc_manager_get_bearer_state:988> type : 1
07-12 16:12:28.136+0800 W/WECONN  (  506): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
07-12 16:12:28.136+0800 W/WECONN  (  506): <__connect_for_auto_switch:1706> { device=0x42903930, device->bt_address=1E:F0
07-12 16:12:28.156+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_expired(1445) > alarm_id[1026269943] is expired.
07-12 16:12:28.156+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:12:28.161+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1026269943)
07-12 16:12:28.166+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1591639436) is OVER.
07-12 16:12:28.166+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 16:12:28.166+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 09:59:08 (UTC).
07-12 16:12:28.171+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 16:12:28.171+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 16:12:28.171+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
07-12 16:12:28.201+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 16:12:28.331+0800 W/WECONN  (  506): <__connect_for_auto_switch:1719> }
07-12 16:12:28.331+0800 W/WECONN  (  506):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
07-12 16:12:28.331+0800 W/WECONN  (  506): <__wc_device_try_to_connect_on_wear:185> }
07-12 16:12:29.376+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[811] goes to (3)
07-12 16:12:29.376+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 811)'s state(3)
07-12 16:12:29.381+0800 W/AUL_AMD (  524): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-12 16:12:29.381+0800 W/AUL_AMD (  524): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-12 16:12:29.381+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(811) status(fg) type(uiapp)
07-12 16:12:29.406+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 13088 pgid = 13088
07-12 16:12:29.406+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-12 16:12:29.416+0800 I/MALI    (  811): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-12 16:12:29.526+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-12 16:12:29.531+0800 I/AUL_AMD (  524): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 13088
07-12 16:12:29.531+0800 W/AUL     (  524): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(13088)
07-12 16:12:29.601+0800 W/CRASH_MANAGER(13232): worker.c: worker_job(1205) > 111308873656e149984714
