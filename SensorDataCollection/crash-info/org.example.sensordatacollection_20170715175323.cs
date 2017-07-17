S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 4942
Date: 2017-07-15 17:53:23+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4942, uid 5000)

Register Information
r0   = 0x4484e390, r1   = 0x413c1c3e
r2   = 0x00000025, r3   = 0x00000000
r4   = 0x401fc1e4, r5   = 0x4484e390
r6   = 0xbeb64b10, r7   = 0x405ab000
r8   = 0x00000000, r9   = 0x40458824
r10  = 0x413c1c3e, fp   = 0xbeb64afc
ip   = 0x413c1c3e, sp   = 0xbeb64590
lr   = 0x404baf50, pc   = 0x404baf74
cpsr = 0x00000010

Memory Information
MemTotal:   491132 KB
MemFree:     37344 KB
Buffers:     16800 KB
Cached:     142052 KB
VmPeak:     108568 KB
VmSize:     107040 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24356 KB
VmRSS:       24352 KB
VmData:      43496 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4942 TID = 4942
4942 5049 5066 5067 5068 

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
41c13000 41d48000 rw-p [heap]
41d48000 41d61000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
43602000 43623000 r-xp /usr/lib/libexif.so.12.3.3
43636000 43638000 r-xp /usr/lib/libttrace.so.1.1
43640000 43645000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4364d000 43653000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4365c000 43664000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4366c000 4368e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43697000 4369e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436a7000 436a9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436b1000 436b8000 r-xp /usr/lib/libminizip.so.1.0.0
436c0000 436cd000 r-xp /usr/lib/libail.so.0.1.0
436d6000 436dc000 r-xp /usr/lib/libproc-stat.so.0.2.96
436e4000 436e5000 r-xp /usr/lib/libresponse.so.0.2.96
436ed000 436f2000 r-xp /usr/lib/libsystem.so.0.0.0
436fc000 437c6000 r-xp /usr/lib/libCOREGL.so.4.0
43c6b000 43c76000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c7f000 43c84000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c8c000 43ca3000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43cb0000 43cb2000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43cbb000 444ba000 rw-p [stack:5049]
444ba000 444bb000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444d1000 444d2000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444f0000 444f8000 r-xp /usr/lib/libfeedback.so.0.1.4
44a8c000 44a8d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44a95000 44a97000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44a9f000 44aaa000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44ab2000 44ab9000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44ac1000 44ad9000 r-xp /usr/lib/libmmfsound.so.0.1.0
44aea000 44aee000 r-xp /usr/lib/libmmfsession.so.0.0.0
44af7000 44b02000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44b0f000 44b13000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44b1b000 44b31000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44b39000 44b9a000 r-xp /usr/lib/libasound.so.2.0.0
44ba4000 44ba7000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44baf000 44be7000 r-xp /usr/lib/libpulse.so.0.16.2
44be8000 44beb000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44bf3000 44c3b000 r-xp /usr/lib/libmdm.so.1.2.62
44c3c000 44c3f000 r-xp /usr/lib/libtinycompress.so.0.0.0
44c47000 44c4c000 r-xp /usr/lib/libjson.so.0.0.1
44c54000 44c9d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44ca6000 44ced000 r-xp /usr/lib/libsndfile.so.1.0.26
44cf9000 44d08000 r-xp /usr/lib/libmdm-common.so.1.1.22
44d11000 44d33000 r-xp /usr/lib/libvorbis.so.0.4.3
44d3b000 44d3f000 r-xp /usr/lib/libogg.so.0.7.1
45048000 45847000 rw-p [stack:5066]
45848000 46047000 rw-p [stack:5067]
46048000 469d5000 rw-p [stack:5068]
beb45000 beb66000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4942)
Call Stack Count: 18
 0: _IO_vfprintf + 0xa4 (0x404baf74) [/lib/libc.so.6] + 0x3df74
 1: _IO_fprintf + 0x1c (0x404c4478) [/lib/libc.so.6] + 0x47478
 2: _data_collection + 0x2a (0x413c171b) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x371b
 3: _new_acceleartion_value + 0x86 (0x413c16df) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x36df
 4: (0x416de127) [/usr/lib/libcapi-system-sensor.so.0] + 0x9127
 5: (0x41734af0) [/usr/lib/libsensor.so.1] + 0x14af0
 6: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 7: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 8: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
 9: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
10: (0x402fe4d5) [/usr/lib/libecore.so.1] + 0xc4d5
11: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
13: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x11a (0x413c029b) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x229b
15: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
16: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
17: _single_line_entry_cb + 0xb (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
 menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:57.891+0800 I/AUL     ( 4944): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:57.891+0800 E/AUL     ( 4944): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:51:57.896+0800 E/AUL     ( 4944): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:51:57.906+0800 I/AUL     ( 4944): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:57.916+0800 I/AUL     ( 4944): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:57.916+0800 E/AUL     ( 4944): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:51:57.921+0800 E/AUL     ( 4944): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:51:57.931+0800 I/AUL     ( 4944): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:57.946+0800 I/AUL     ( 4944): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:57.946+0800 E/AUL     ( 4944): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:51:57.946+0800 E/AUL     ( 4944): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:51:57.961+0800 I/AUL     ( 4944): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:57.971+0800 I/AUL     ( 4944): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:57.971+0800 E/AUL     ( 4944): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:51:57.971+0800 E/AUL     ( 4944): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:51:57.986+0800 I/AUL     ( 4944): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:57.996+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:51:57.996+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:51:58.006+0800 I/AUL     ( 4944): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:58.006+0800 E/AUL     ( 4944): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:51:58.006+0800 E/AUL     ( 4944): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:51:58.021+0800 I/AUL     ( 4944): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:58.051+0800 I/AUL     ( 4944): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:58.051+0800 E/AUL     ( 4944): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:51:58.051+0800 E/AUL     ( 4944): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:51:58.106+0800 I/UXT     ( 4944): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-15 17:51:58.206+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:51:58.206+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:51:58.286+0800 E/PKGMGR_SERVER( 4931): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-15 17:51:58.336+0800 E/MALI    ( 4944): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-15 17:51:58.341+0800 E/MALI    ( 4944): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-15 17:51:58.341+0800 E/MALI    ( 4944): [gpu-ddk] devel/graphics_drv/r4p0
07-15 17:51:58.341+0800 E/MALI    ( 4944): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-15 17:51:58.341+0800 E/MALI    ( 4944): [coregl] devel/graphics_engine/master
07-15 17:51:58.341+0800 E/MALI    ( 4944): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-15 17:51:58.401+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:51:58.401+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:51:58.576+0800 E/rpm-installer( 4932): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-15 17:51:58.576+0800 E/rpm-installer( 4932): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-15 17:51:58.576+0800 E/rpm-installer( 4932): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-15 17:51:58.596+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:51:58.596+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:51:58.621+0800 E/PKGMGR_SERVER( 4931): pkgmgr-server.c: sighandler(486) > child NORMAL exit [4932]
07-15 17:51:58.796+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:51:58.796+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:51:59.001+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:51:59.001+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:51:59.196+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:51:59.196+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:51:59.461+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:51:59.461+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:51:59.601+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:51:59.601+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:51:59.636+0800 I/MALI    ( 4944): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-15 17:51:59.641+0800 E/MALI    ( 4944): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-15 17:51:59.661+0800 I/AUL     ( 4953): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-15 17:51:59.701+0800 I/AUL     ( 4953): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:51:59.701+0800 E/AUL     ( 4953): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:51:59.701+0800 E/AUL     ( 4953): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:51:59.706+0800 W/AUL     ( 5012): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-15 17:51:59.706+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 0
07-15 17:51:59.721+0800 I/AUL_AMD (  522): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-15 17:51:59.731+0800 I/AUL_AMD (  522): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-15 17:51:59.731+0800 E/AUL_AMD (  522): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-15 17:51:59.731+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(1782) > caller pid : 5012
07-15 17:51:59.741+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(2218) > pad pid(-5)
07-15 17:51:59.741+0800 E/RESOURCED(  608): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 1
07-15 17:51:59.746+0800 W/AUL_PAD ( 1293): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-15 17:51:59.746+0800 W/AUL_PAD ( 1293): launchpad.c: __send_result_to_caller(272) > Check app launching
07-15 17:51:59.746+0800 W/AUL_PAD ( 4942): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-15 17:51:59.746+0800 W/AUL_PAD ( 4942): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-15 17:51:59.746+0800 W/AUL_PAD ( 4942): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-15 17:51:59.746+0800 W/AUL_PAD ( 4942): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-15 17:51:59.801+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:51:59.801+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:51:59.806+0800 I/efl-extension( 4942): efl_extension.c: eext_mod_init(40) > Init
07-15 17:51:59.811+0800 I/UXT     ( 4942): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-15 17:51:59.831+0800 W/AUL_PAD ( 4942): launchpad_loader.c: main(690) > [candidate] dlsym
07-15 17:51:59.831+0800 W/AUL_PAD ( 4942): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-15 17:51:59.836+0800 I/CAPI_APPFW_APPLICATION( 4942): app_main.c: ui_app_main(704) > app_efl_main
07-15 17:51:59.841+0800 I/CAPI_APPFW_APPLICATION( 4942): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-15 17:51:59.846+0800 W/AUL     (  522): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(4942) type(uiapp) bg(0)
07-15 17:51:59.846+0800 W/AUL_AMD (  522): amd_status.c: __socket_monitor_cb(1277) > (4942) was created
07-15 17:51:59.846+0800 W/AUL     ( 5012): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4942)
07-15 17:51:59.901+0800 W/STARTER (  767): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [4942]
07-15 17:51:59.921+0800 E/WMS     (  520): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-15 17:51:59.996+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:51:59.996+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:52:00.076+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 17:52:00.076+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-15 17:52:00.076+0800 I/efl-extension( 4942): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-15 17:52:00.076+0800 I/efl-extension( 4942): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-15 17:52:00.076+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x437ece38, elm_image, _activated_obj : 0x0, activated : 1
07-15 17:52:00.081+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 17:52:00.086+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x437ed2a0) will be pushed
07-15 17:52:00.086+0800 I/efl-extension( 4942): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x4383bca0]'s widget[0x437ee730] to layout widget[0x437ed2a0]
07-15 17:52:00.091+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437dc910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:52:00.091+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437dc910 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-15 17:52:00.091+0800 I/efl-extension( 4942): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 17:52:00.101+0800 I/APP_CORE( 4942): appcore-efl.c: __do_app(453) > [APP 4942] Event: RESET State: CREATED
07-15 17:52:00.101+0800 I/CAPI_APPFW_APPLICATION( 4942): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-15 17:52:00.121+0800 I/APP_CORE( 4942): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-15 17:52:00.121+0800 I/APP_CORE( 4942): appcore-efl.c: __do_app(524) > [APP 4942] Initial Launching, call the resume_cb
07-15 17:52:00.121+0800 I/CAPI_APPFW_APPLICATION( 4942): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-15 17:52:00.131+0800 W/W_HOME  (  810): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-15 17:52:00.131+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:52:00.131+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:52:00.131+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:52:00.131+0800 W/W_HOME  (  810): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-15 17:52:00.136+0800 W/W_INDICATOR(  768): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-15 17:52:00.136+0800 W/W_INDICATOR(  768): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-15 17:52:00.166+0800 W/APP_CORE( 4942): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1600002
07-15 17:52:00.171+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437dc910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:52:00.171+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437dc910 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-15 17:52:00.196+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:52:00.196+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:52:00.211+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437dc910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-15 17:52:00.211+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437dc910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-15 17:52:00.236+0800 I/MALI    (  810): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-15 17:52:00.286+0800 E/PKGMGR_SERVER( 4931): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-15 17:52:00.286+0800 E/PKGMGR_SERVER( 4931): pkgmgr-server.c: main(2296) > package manager server terminated.
07-15 17:52:00.321+0800 W/W_HOME  (  810): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-15 17:52:00.321+0800 W/W_HOME  (  810): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-15 17:52:00.321+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:52:00.321+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:52:00.321+0800 W/W_HOME  (  810): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-15 17:52:00.341+0800 I/APP_CORE(  810): appcore-efl.c: __do_app(453) > [APP 810] Event: PAUSE State: RUNNING
07-15 17:52:00.341+0800 I/CAPI_APPFW_APPLICATION(  810): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-15 17:52:00.346+0800 W/W_HOME  (  810): main.c: _appcore_pause_cb(487) > appcore pause
07-15 17:52:00.351+0800 W/W_HOME  (  810): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-15 17:52:00.351+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:52:00.351+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:52:00.351+0800 W/W_INDICATOR(  768): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-15 17:52:00.351+0800 W/W_HOME  (  810): main.c: home_pause(546) > clock/widget paused
07-15 17:52:00.356+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:52:00.361+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-15 17:52:00.361+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-15 17:52:00.361+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-15 17:52:00.361+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-15 17:52:00.361+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-15 17:52:00.361+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-15 17:52:00.361+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-15 17:52:00.361+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-15 17:52:00.376+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-15 17:52:00.376+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-15 17:52:00.376+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-15 17:52:00.376+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-15 17:52:00.376+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-15 17:52:00.376+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-15 17:52:00.376+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-15 17:52:00.376+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-15 17:52:00.376+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-15 17:52:00.376+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-15 17:52:00.376+0800 E/CAPI_APPFW_APP_CONTROL( 1014): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-15 17:52:00.376+0800 W/MUSIC_CONTROL_SERVICE( 1014): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1014]   [com.samsung.w-home]register msg port [false][0m
07-15 17:52:00.386+0800 I/wnotib  (  810): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-15 17:52:00.391+0800 E/wnotib  (  810): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-15 17:52:00.391+0800 W/wnotib  (  810): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-15 17:52:00.391+0800 W/WATCH_CORE(  909): appcore-watch.c: __widget_pause(1113) > widget_pause
07-15 17:52:00.391+0800 W/AUL     (  909): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(909) status(bg) type(watchapp)
07-15 17:52:00.391+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppPause(589) > 
07-15 17:52:00.396+0800 W/STARTER (  767): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[810] goes to (4)
07-15 17:52:00.396+0800 E/STARTER (  767): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 810)'s state(4)
07-15 17:52:00.396+0800 I/APP_CORE( 4942): appcore-efl.c: __do_app(453) > [APP 4942] Event: RESUME State: RUNNING
07-15 17:52:00.396+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(810) status(bg) type(uiapp)
07-15 17:52:00.401+0800 W/STARTER (  767): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4942] goes to (3)
07-15 17:52:00.401+0800 W/AUL_AMD (  522): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-15 17:52:00.401+0800 W/AUL_AMD (  522): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-15 17:52:00.401+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(4942) status(fg) type(uiapp)
07-15 17:52:00.416+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 17:52:00.421+0800 W/W_INDICATOR(  768): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-15 17:52:00.456+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
07-15 17:52:00.456+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
07-15 17:52:00.456+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: preference_get_double(1214) > preference_get_double(1118) : pedometer_inactive_period error
07-15 17:52:00.456+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
07-15 17:52:00.461+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
07-15 17:52:00.461+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: preference_get_boolean(1173) > preference_get_boolean(1118) : inactive_test_mode_on error
07-15 17:52:00.461+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 17:52:00.491+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 17:52:00.706+0800 E/AUL     (  522): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-15 17:52:00.811+0800 W/WATCH_CORE(  909): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-15 17:52:00.811+0800 I/WATCH_CORE(  909): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-15 17:52:00.811+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:52:00.811+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:52:00.811+0800 I/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-15 17:52:00.826+0800 E/wnoti-service( 1056): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 1 to 2 
07-15 17:52:00.831+0800 E/WMS     (  520): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 1 -> 2
07-15 17:52:00.846+0800 W/WECONN  (  502): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
07-15 17:52:00.846+0800 W/WECONN  (  502): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_OFF
07-15 17:52:00.846+0800 W/WECONN  (  502): <__wc_device_on_wear_onoff_changed_cb:385> }
07-15 17:52:00.846+0800 W/WECONN  (  502): <__wc_feature_wearonoff_monitor_cb:531> }
07-15 17:52:00.886+0800 I/APP_CORE(  810): appcore-efl.c: __do_app(453) > [APP 810] Event: MEM_FLUSH State: PAUSED
07-15 17:52:00.991+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-15 17:52:01.001+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4942
07-15 17:52:01.001+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-15 17:52:01.016+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-15 17:52:01.026+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4942
07-15 17:52:01.031+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-15 17:52:01.036+0800 W/SHealthService( 1118): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
07-15 17:52:01.246+0800 I/AUL_PAD ( 5014): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-15 17:52:05.391+0800 I/APP_CORE(  810): appcore-efl.c: __do_app(453) > [APP 810] Event: MEM_FLUSH State: PAUSED
07-15 17:52:13.236+0800 E/WMS     (  520): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-15 17:52:37.996+0800 W/SHealthCommon( 1118): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1500076800000.000000[0;m
07-15 17:52:38.056+0800 W/SHealthCommon( 1118): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-15 17:52:38.086+0800 I/HealthDataService(  998): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-15 17:52:38.126+0800 I/healthData( 1118): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-15 17:52:58.241+0800 E/WMS     (  520): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-15 17:53:00.326+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 17:53:00.401+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
07-15 17:53:00.401+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
07-15 17:53:00.406+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: preference_get_double(1214) > preference_get_double(1118) : pedometer_inactive_period error
07-15 17:53:00.406+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
07-15 17:53:00.416+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
07-15 17:53:00.416+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1118): preference.c: preference_get_boolean(1173) > preference_get_boolean(1118) : inactive_test_mode_on error
07-15 17:53:00.416+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 17:53:00.451+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 17:53:00.896+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 17:53:00.976+0800 E/SHealthService( 1118): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-15 17:53:00.986+0800 W/SHealthService( 1118): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(379) > [1;40;33mOnNotWearingStart[0;m
07-15 17:53:01.111+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 17:53:01.136+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 17:53:01.146+0800 W/SHealthCommon( 1118): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1500076800000.000000[0;m
07-15 17:53:01.166+0800 W/SHealthCommon( 1118): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-15 17:53:01.171+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 17:53:01.186+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 17:53:01.196+0800 W/SHealthService( 1118): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 17:53:01.211+0800 W/SHealthCommon( 1118): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-15 17:53:01.216+0800 I/HealthDataService(  998): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-15 17:53:01.236+0800 I/healthData( 1118): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-15 17:53:07.931+0800 E/EFL     ( 4942): ecore_x<4942> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2489646 button=1
07-15 17:53:07.931+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] mouse move
07-15 17:53:07.936+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] mouse move
07-15 17:53:07.936+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] hold(0), freeze(0)
07-15 17:53:07.936+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] mouse move
07-15 17:53:07.936+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] hold(0), freeze(0)
07-15 17:53:07.941+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] mouse move
07-15 17:53:07.941+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] hold(0), freeze(0)
07-15 17:53:07.951+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] mouse move
07-15 17:53:07.951+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] hold(0), freeze(0)
07-15 17:53:07.971+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] mouse move
07-15 17:53:07.971+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] hold(0), freeze(0)
07-15 17:53:07.981+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] mouse move
07-15 17:53:07.981+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] hold(0), freeze(0)
07-15 17:53:08.016+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] mouse move
07-15 17:53:08.016+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437dc910 : elm_genlist] hold(0), freeze(0)
07-15 17:53:08.046+0800 E/EFL     ( 4942): ecore_x<4942> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2489762 button=1
07-15 17:53:08.051+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437dc910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-15 17:53:08.051+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437dc910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-15 17:53:08.051+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x437dc910 : elm_genlist] x(0), y(130)
07-15 17:53:08.051+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x437dc910 : elm_genlist] t_in(0.300000), pos_x(0)
07-15 17:53:08.051+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x437dc910 : elm_genlist] t_in(0.300000), pos_y(130)
07-15 17:53:08.056+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437dc910 : elm_genlist] time(0.057462)
07-15 17:53:08.056+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437dc910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-15 17:53:08.056+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437dc910 : elm_genlist] time(0.057462)
07-15 17:53:08.061+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437dc910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(7)
07-15 17:53:08.331+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437dc910 : elm_genlist] time(0.345362)
07-15 17:53:08.331+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437dc910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(7)
07-15 17:53:08.331+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437dc910 : elm_genlist] time(0.345362)
07-15 17:53:08.331+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437dc910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(44)
07-15 17:53:08.371+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437dc910 : elm_genlist] time(0.994907)
07-15 17:53:08.371+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x437dc910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(44)
07-15 17:53:08.371+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437dc910 : elm_genlist] time(0.994907)
07-15 17:53:08.371+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x437dc910 : elm_genlist] animation stop!!
07-15 17:53:08.396+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 17:53:08.396+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44778e60, elm_image, _activated_obj : 0x437ece38, activated : 1
07-15 17:53:08.396+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 17:53:08.416+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44777100 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 17:53:08.421+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44777100 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 17:53:08.441+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 17:53:08.451+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44d4a160) will be pushed
07-15 17:53:08.451+0800 I/efl-extension( 4942): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44d72420]'s widget[0x44d6a790] to layout widget[0x44d4a160]
07-15 17:53:08.456+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44777100 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 17:53:08.456+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44777100 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 17:53:08.456+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44777100 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 17:53:08.456+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44777100 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 17:53:08.456+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44777100 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 17:53:08.456+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44777100 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 17:53:08.461+0800 I/efl-extension( 4942): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 17:53:08.466+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x437dc910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-15 17:53:08.501+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:2796 _push_transition_cb() item(0x44d4a160) will transition
07-15 17:53:08.921+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:1193 _on_item_push_finished() item(0x437ed2a0) transition finished
07-15 17:53:08.921+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:1218 _on_item_show_finished() item(0x44d4a160) transition finished
07-15 17:53:09.061+0800 E/EFL     (  461): ecore_x<461> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1600002 time=2490187
07-15 17:53:09.066+0800 E/EFL     ( 4942): ecore_x<4942> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=2490187
07-15 17:53:09.066+0800 E/EFL     (  461): ecore_x<461> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=2490187
07-15 17:53:09.421+0800 E/EFL     ( 4942): ecore_x<4942> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2491133 button=1
07-15 17:53:09.446+0800 E/EFL     ( 4942): ecore_x<4942> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2491155 button=1
07-15 17:53:13.466+0800 E/EFL     ( 4942): elementary<4942> elm_genlist.c:7001 elm_genlist_item_selected_set() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-15 17:53:13.596+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 17:53:13.601+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44d49138, elm_image, _activated_obj : 0x44778e60, activated : 1
07-15 17:53:13.606+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 17:53:13.651+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d6b7b8 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 17:53:13.651+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d6b7b8 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 17:53:13.651+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 17:53:13.681+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4476c1e8) will be pushed
07-15 17:53:13.681+0800 I/efl-extension( 4942): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44e18108]'s widget[0x44e14448] to layout widget[0x4476c1e8]
07-15 17:53:13.691+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d6b7b8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:53:13.691+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d6b7b8 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:53:13.696+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d6b7b8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:53:13.696+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d6b7b8 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:53:13.696+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d6b7b8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:53:13.696+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d6b7b8 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:53:13.696+0800 I/efl-extension( 4942): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 17:53:13.751+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:2796 _push_transition_cb() item(0x4476c1e8) will transition
07-15 17:53:14.171+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:1193 _on_item_push_finished() item(0x44d4a160) transition finished
07-15 17:53:14.171+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:1218 _on_item_show_finished() item(0x4476c1e8) transition finished
07-15 17:53:23.086+0800 E/RESOURCED(  608): block-monitor.c: block_logging(123) > pid 4942(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/admin/2017-07-15-17--53-acc.txt
07-15 17:53:23.086+0800 E/RESOURCED(  608): block-monitor.c: block_logging(123) > pid 4942(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/admin/2017-07-15-17--53-gyr.txt
07-15 17:53:23.151+0800 E/EFL     ( 4942): elementary<4942> elm_genlist.c:7001 elm_genlist_item_selected_set() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-15 17:53:23.171+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 17:53:23.171+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44e14a28, elm_image, _activated_obj : 0x44d49138, activated : 1
07-15 17:53:23.171+0800 I/efl-extension( 4942): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 17:53:23.186+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44e152f8 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 17:53:23.186+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44e152f8 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 17:53:23.191+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 17:53:23.211+0800 E/EFL     ( 4942): elementary<4942> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44e1be48) will be pushed
07-15 17:53:23.211+0800 I/efl-extension( 4942): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44e2c4c0]'s widget[0x44e326f8] to layout widget[0x44e1be48]
07-15 17:53:23.216+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44e152f8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:53:23.221+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44e152f8 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:53:23.221+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44e152f8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:53:23.221+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44e152f8 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:53:23.221+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44e152f8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:53:23.221+0800 E/EFL     ( 4942): elementary<4942> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44e152f8 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:53:23.221+0800 I/efl-extension( 4942): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 17:53:23.616+0800 W/CRASH_MANAGER( 5094): worker.c: worker_job(1205) > 110494273656e150011240
