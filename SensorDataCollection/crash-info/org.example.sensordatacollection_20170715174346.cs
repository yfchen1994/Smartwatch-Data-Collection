S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 4298
Date: 2017-07-15 17:43:46+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4298, uid 5000)

Register Information
r0   = 0xffffffff, r1   = 0x00000001
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xffffffff, r5   = 0x44d1a6a0
r6   = 0x403866a8, r7   = 0x401f15c0
r8   = 0x000002a4, r9   = 0x401db9e0
r10  = 0x401dbaa4, fp   = 0x401db204
ip   = 0x40795d9c, sp   = 0xbeb76dd8
lr   = 0x404ef5d0, pc   = 0x4036540a
cpsr = 0x60000030

Memory Information
MemTotal:   491132 KB
MemFree:      9332 KB
Buffers:     21368 KB
Cached:     140444 KB
VmPeak:     110408 KB
VmSize:     108880 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26216 KB
VmRSS:       26212 KB
VmData:      45336 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4298 TID = 4298
4298 4381 4397 4398 4399 

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
43c7f000 4447e000 rw-p [stack:4381]
4447e000 4447f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444d9000 444da000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44a4c000 44a54000 r-xp /usr/lib/libfeedback.so.0.1.4
44a56000 44a57000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44a5f000 44a61000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44a69000 44a74000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44a7c000 44a83000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44a8b000 44aa3000 r-xp /usr/lib/libmmfsound.so.0.1.0
44ab4000 44ab8000 r-xp /usr/lib/libmmfsession.so.0.0.0
44ac1000 44acc000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44ad9000 44add000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44ae5000 44afb000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44b03000 44b64000 r-xp /usr/lib/libasound.so.2.0.0
44b6e000 44b71000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44b79000 44bb1000 r-xp /usr/lib/libpulse.so.0.16.2
44bb2000 44bb5000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44bbd000 44c05000 r-xp /usr/lib/libmdm.so.1.2.62
44c06000 44c09000 r-xp /usr/lib/libtinycompress.so.0.0.0
44c11000 44c16000 r-xp /usr/lib/libjson.so.0.0.1
44c1e000 44c67000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44c70000 44cb7000 r-xp /usr/lib/libsndfile.so.1.0.26
44cc3000 44cd2000 r-xp /usr/lib/libmdm-common.so.1.1.22
44cdb000 44cfd000 r-xp /usr/lib/libvorbis.so.0.4.3
44d05000 44d09000 r-xp /usr/lib/libogg.so.0.7.1
45012000 45811000 rw-p [stack:4397]
45812000 46011000 rw-p [stack:4398]
46012000 46ba1000 rw-p [stack:4399]
beb57000 beb78000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4298)
Call Stack Count: 33
 0: (0x4036540a) [/usr/lib/libedje.so.1] + 0x4540a
 1: (0x4036af83) [/usr/lib/libedje.so.1] + 0x4af83
 2: (0x40234ff3) [/usr/lib/libevas.so.1] + 0x35ff3
 3: evas_object_del + 0x194 (0x4022dd39) [/usr/lib/libevas.so.1] + 0x2ed39
 4: (0x401a4a4f) [/usr/lib/libelementary.so.1] + 0xf8a4f
 5: (0x4015f951) [/usr/lib/libelementary.so.1] + 0xb3951
 6: (0x40234ff3) [/usr/lib/libevas.so.1] + 0x35ff3
 7: evas_object_del + 0x194 (0x4022dd39) [/usr/lib/libevas.so.1] + 0x2ed39
 8: (0x401a4a4f) [/usr/lib/libelementary.so.1] + 0xf8a4f
 9: (0x4015f951) [/usr/lib/libelementary.so.1] + 0xb3951
10: (0x40234ff3) [/usr/lib/libevas.so.1] + 0x35ff3
11: evas_object_del + 0x194 (0x4022dd39) [/usr/lib/libevas.so.1] + 0x2ed39
12: (0x401a4a4f) [/usr/lib/libelementary.so.1] + 0xf8a4f
13: (0x4015f951) [/usr/lib/libelementary.so.1] + 0xb3951
14: (0x40234ff3) [/usr/lib/libevas.so.1] + 0x35ff3
15: evas_object_del + 0x194 (0x4022dd39) [/usr/lib/libevas.so.1] + 0x2ed39
16: _elm_widget_item_free + 0x76 (0x401a93ef) [/usr/lib/libelementary.so.1] + 0xfd3ef
17: (0x4015c9b5) [/usr/lib/libelementary.so.1] + 0xb09b5
18: (0x40365f0d) [/usr/lib/libedje.so.1] + 0x45f0d
19: (0x40369efd) [/usr/lib/libedje.so.1] + 0x49efd
20: (0x40366869) [/usr/lib/libedje.so.1] + 0x46869
21: (0x40366c1b) [/usr/lib/libedje.so.1] + 0x46c1b
22: (0x40366d55) [/usr/lib/libedje.so.1] + 0x46d55
23: (0x402fd3f5) [/usr/lib/libecore.so.1] + 0xb3f5
24: (0x402fae53) [/usr/lib/libecore.so.1] + 0x8e53
25: (0x402fe46b) [/usr/lib/libecore.so.1] + 0xc46b
26: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
27: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
28: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
29: main + 0x11a (0x414c029b) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x229b
30: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
31: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
32: _single_line_entry_cb + 0xb (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
didate, ret : 0
07-15 17:43:24.461+0800 E/AUL     ( 4297): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:43:24.461+0800 E/AUL     ( 4297): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:43:24.476+0800 I/AUL     ( 4297): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:43:24.486+0800 I/AUL     ( 4297): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:43:24.491+0800 E/AUL     ( 4297): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:43:24.491+0800 E/AUL     ( 4297): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:43:24.501+0800 I/AUL     ( 4297): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:43:24.516+0800 I/AUL     ( 4297): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:43:24.516+0800 E/AUL     ( 4297): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:43:24.516+0800 E/AUL     ( 4297): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:43:24.531+0800 I/AUL     ( 4297): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:43:24.546+0800 I/AUL     ( 4297): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:43:24.551+0800 E/AUL     ( 4297): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:43:24.551+0800 E/AUL     ( 4297): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:43:24.566+0800 I/AUL     ( 4297): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:43:24.581+0800 I/AUL     ( 4297): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:43:24.581+0800 E/AUL     ( 4297): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:43:24.581+0800 E/AUL     ( 4297): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:43:24.596+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:24.596+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:24.616+0800 I/UXT     ( 4297): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-15 17:43:24.796+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:24.796+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:24.846+0800 E/MALI    ( 4297): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-15 17:43:24.851+0800 E/MALI    ( 4297): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-15 17:43:24.851+0800 E/MALI    ( 4297): [gpu-ddk] devel/graphics_drv/r4p0
07-15 17:43:24.851+0800 E/MALI    ( 4297): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-15 17:43:24.851+0800 E/MALI    ( 4297): [coregl] devel/graphics_engine/master
07-15 17:43:24.851+0800 E/MALI    ( 4297): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-15 17:43:24.851+0800 E/MALI    ( 4297): 
07-15 17:43:24.996+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:24.996+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:25.196+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:25.196+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:25.286+0800 E/PKGMGR_SERVER( 4233): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-15 17:43:25.396+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:25.396+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:25.596+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:25.596+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:25.716+0800 E/rpm-installer( 4287): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-15 17:43:25.716+0800 E/rpm-installer( 4287): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-15 17:43:25.716+0800 E/rpm-installer( 4287): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-15 17:43:25.771+0800 E/RESOURCED(  608): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/4287/oom_score_adj failed
07-15 17:43:25.771+0800 E/RESOURCED(  608): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 4287
07-15 17:43:25.771+0800 E/PKGMGR_SERVER( 4233): pkgmgr-server.c: sighandler(486) > child NORMAL exit [4287]
07-15 17:43:25.796+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:25.796+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:25.941+0800 I/MALI    ( 4297): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-15 17:43:25.946+0800 E/MALI    ( 4297): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-15 17:43:25.966+0800 I/AUL     ( 4308): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-15 17:43:25.981+0800 I/AUL     ( 4308): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-15 17:43:25.981+0800 E/AUL     ( 4308): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-15 17:43:25.981+0800 E/AUL     ( 4308): aul_path.c: __get_path(169) > root_path is NULL!
07-15 17:43:25.996+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:25.996+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:26.196+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:26.201+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:26.401+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:26.401+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:26.606+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:26.606+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:26.801+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:26.801+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:27.001+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:27.001+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:27.201+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:27.201+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:27.286+0800 E/PKGMGR_SERVER( 4233): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-15 17:43:27.286+0800 E/PKGMGR_SERVER( 4233): pkgmgr-server.c: main(2296) > package manager server terminated.
07-15 17:43:27.396+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:27.396+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:27.601+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:27.601+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:27.736+0800 W/AUL     ( 4367): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-15 17:43:27.736+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 0
07-15 17:43:27.756+0800 I/AUL_AMD (  522): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-15 17:43:27.776+0800 I/AUL_AMD (  522): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-15 17:43:27.776+0800 E/AUL_AMD (  522): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-15 17:43:27.776+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(1782) > caller pid : 4367
07-15 17:43:27.791+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(2218) > pad pid(-5)
07-15 17:43:27.791+0800 W/AUL_PAD ( 1293): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-15 17:43:27.791+0800 W/AUL_PAD ( 1293): launchpad.c: __send_result_to_caller(272) > Check app launching
07-15 17:43:27.791+0800 E/RESOURCED(  608): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 1
07-15 17:43:27.791+0800 W/AUL_PAD ( 4298): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-15 17:43:27.796+0800 W/AUL_PAD ( 4298): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-15 17:43:27.796+0800 W/AUL_PAD ( 4298): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-15 17:43:27.796+0800 W/AUL_PAD ( 4298): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-15 17:43:27.801+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:27.801+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:27.871+0800 I/efl-extension( 4298): efl_extension.c: eext_mod_init(40) > Init
07-15 17:43:27.876+0800 I/UXT     ( 4298): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-15 17:43:27.896+0800 W/AUL_PAD ( 4298): launchpad_loader.c: main(690) > [candidate] dlsym
07-15 17:43:27.896+0800 W/AUL_PAD ( 4298): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-15 17:43:27.901+0800 I/CAPI_APPFW_APPLICATION( 4298): app_main.c: ui_app_main(704) > app_efl_main
07-15 17:43:27.906+0800 I/CAPI_APPFW_APPLICATION( 4298): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-15 17:43:27.991+0800 W/AUL     (  522): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(4298) type(uiapp) bg(0)
07-15 17:43:27.991+0800 W/AUL     ( 4367): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4298)
07-15 17:43:27.996+0800 W/AUL_AMD (  522): amd_status.c: __socket_monitor_cb(1277) > (4298) was created
07-15 17:43:27.996+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:27.996+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:28.001+0800 W/STARTER (  767): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [4298]
07-15 17:43:28.116+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 17:43:28.116+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-15 17:43:28.116+0800 I/efl-extension( 4298): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-15 17:43:28.116+0800 I/efl-extension( 4298): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-15 17:43:28.116+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445065b8, elm_image, _activated_obj : 0x0, activated : 1
07-15 17:43:28.121+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 17:43:28.126+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44506a20) will be pushed
07-15 17:43:28.126+0800 I/efl-extension( 4298): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x417f7320]'s widget[0x44507eb0] to layout widget[0x44506a20]
07-15 17:43:28.131+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96f8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:28.131+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96f8 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-15 17:43:28.131+0800 I/efl-extension( 4298): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 17:43:28.141+0800 I/APP_CORE( 4298): appcore-efl.c: __do_app(453) > [APP 4298] Event: RESET State: CREATED
07-15 17:43:28.141+0800 I/CAPI_APPFW_APPLICATION( 4298): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-15 17:43:28.161+0800 I/APP_CORE( 4298): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-15 17:43:28.161+0800 I/APP_CORE( 4298): appcore-efl.c: __do_app(524) > [APP 4298] Initial Launching, call the resume_cb
07-15 17:43:28.161+0800 I/CAPI_APPFW_APPLICATION( 4298): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-15 17:43:28.181+0800 W/W_HOME  (  810): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-15 17:43:28.181+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:43:28.181+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:43:28.186+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:43:28.186+0800 W/W_INDICATOR(  768): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-15 17:43:28.186+0800 W/W_HOME  (  810): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-15 17:43:28.186+0800 W/W_INDICATOR(  768): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-15 17:43:28.191+0800 W/APP_CORE( 4298): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1600002
07-15 17:43:28.201+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:28.201+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:28.211+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96f8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:28.211+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96f8 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-15 17:43:28.246+0800 I/MALI    (  810): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-15 17:43:28.281+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96f8 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-15 17:43:28.281+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96f8 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-15 17:43:28.366+0800 W/W_HOME  (  810): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-15 17:43:28.366+0800 W/W_HOME  (  810): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-15 17:43:28.366+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:43:28.366+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:43:28.366+0800 W/W_HOME  (  810): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-15 17:43:28.366+0800 I/APP_CORE(  810): appcore-efl.c: __do_app(453) > [APP 810] Event: PAUSE State: RUNNING
07-15 17:43:28.366+0800 I/CAPI_APPFW_APPLICATION(  810): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-15 17:43:28.366+0800 W/W_HOME  (  810): main.c: _appcore_pause_cb(487) > appcore pause
07-15 17:43:28.366+0800 W/W_HOME  (  810): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-15 17:43:28.366+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:43:28.366+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:43:28.366+0800 W/W_HOME  (  810): main.c: home_pause(546) > clock/widget paused
07-15 17:43:28.366+0800 W/W_HOME  (  810): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-15 17:43:28.366+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-15 17:43:28.366+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-15 17:43:28.366+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-15 17:43:28.366+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-15 17:43:28.366+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-15 17:43:28.366+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-15 17:43:28.366+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-15 17:43:28.366+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-15 17:43:28.371+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-15 17:43:28.371+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-15 17:43:28.371+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-15 17:43:28.371+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-15 17:43:28.371+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-15 17:43:28.371+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-15 17:43:28.371+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-15 17:43:28.371+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-15 17:43:28.371+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-15 17:43:28.371+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-15 17:43:28.371+0800 W/W_INDICATOR(  768): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-15 17:43:28.371+0800 W/W_INDICATOR(  768): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-15 17:43:28.371+0800 E/CAPI_APPFW_APP_CONTROL( 1014): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-15 17:43:28.371+0800 W/MUSIC_CONTROL_SERVICE( 1014): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1014]   [com.samsung.w-home]register msg port [false][0m
07-15 17:43:28.381+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(810) status(bg) type(uiapp)
07-15 17:43:28.381+0800 W/AUL_AMD (  522): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-15 17:43:28.381+0800 W/AUL_AMD (  522): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-15 17:43:28.381+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(4298) status(fg) type(uiapp)
07-15 17:43:28.386+0800 W/STARTER (  767): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[810] goes to (4)
07-15 17:43:28.386+0800 E/STARTER (  767): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 810)'s state(4)
07-15 17:43:28.386+0800 W/STARTER (  767): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4298] goes to (3)
07-15 17:43:28.396+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 17:43:28.396+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 17:43:28.401+0800 I/wnotib  (  810): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-15 17:43:28.401+0800 E/wnotib  (  810): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-15 17:43:28.401+0800 W/wnotib  (  810): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-15 17:43:28.406+0800 W/WATCH_CORE(  909): appcore-watch.c: __widget_pause(1113) > widget_pause
07-15 17:43:28.406+0800 W/AUL     (  909): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(909) status(bg) type(watchapp)
07-15 17:43:28.406+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppPause(589) > 
07-15 17:43:28.466+0800 E/TBM     (  461): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:461] error(Device or resource busy) _tgl_destroy:141 key:43
07-15 17:43:28.471+0800 I/APP_CORE( 4298): appcore-efl.c: __do_app(453) > [APP 4298] Event: RESUME State: RUNNING
07-15 17:43:28.771+0800 E/AUL     (  522): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-15 17:43:28.871+0800 I/APP_CORE(  810): appcore-efl.c: __do_app(453) > [APP 810] Event: MEM_FLUSH State: PAUSED
07-15 17:43:29.201+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-15 17:43:29.211+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4298
07-15 17:43:29.211+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-15 17:43:29.226+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-15 17:43:29.236+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4298
07-15 17:43:29.241+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-15 17:43:29.481+0800 I/AUL_PAD ( 4369): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-15 17:43:30.411+0800 E/EFL     ( 4298): ecore_x<4298> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1912124 button=1
07-15 17:43:30.411+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] mouse move
07-15 17:43:30.431+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] mouse move
07-15 17:43:30.431+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] hold(0), freeze(0)
07-15 17:43:30.441+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] mouse move
07-15 17:43:30.441+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] hold(0), freeze(0)
07-15 17:43:30.451+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] mouse move
07-15 17:43:30.451+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] hold(0), freeze(0)
07-15 17:43:30.461+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] mouse move
07-15 17:43:30.461+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] hold(0), freeze(0)
07-15 17:43:30.471+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] mouse move
07-15 17:43:30.471+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] hold(0), freeze(0)
07-15 17:43:30.496+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] mouse move
07-15 17:43:30.496+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] hold(0), freeze(0)
07-15 17:43:30.506+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] mouse move
07-15 17:43:30.506+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96f8 : elm_genlist] hold(0), freeze(0)
07-15 17:43:30.516+0800 E/EFL     ( 4298): ecore_x<4298> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1912231 button=1
07-15 17:43:30.521+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96f8 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-15 17:43:30.521+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96f8 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-15 17:43:30.521+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x417e96f8 : elm_genlist] x(0), y(130)
07-15 17:43:30.521+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x417e96f8 : elm_genlist] t_in(0.300000), pos_x(0)
07-15 17:43:30.521+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x417e96f8 : elm_genlist] t_in(0.300000), pos_y(130)
07-15 17:43:30.521+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96f8 : elm_genlist] time(0.026921)
07-15 17:43:30.521+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96f8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-15 17:43:30.521+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96f8 : elm_genlist] time(0.026921)
07-15 17:43:30.521+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96f8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(3)
07-15 17:43:30.796+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96f8 : elm_genlist] time(0.254418)
07-15 17:43:30.796+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96f8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(3)
07-15 17:43:30.796+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96f8 : elm_genlist] time(0.254418)
07-15 17:43:30.801+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96f8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(33)
07-15 17:43:30.866+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96f8 : elm_genlist] time(0.974299)
07-15 17:43:30.866+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x417e96f8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(33)
07-15 17:43:30.866+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96f8 : elm_genlist] time(0.974299)
07-15 17:43:30.871+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x417e96f8 : elm_genlist] animation stop!!
07-15 17:43:30.906+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 17:43:30.906+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4472ea10, elm_image, _activated_obj : 0x445065b8, activated : 1
07-15 17:43:30.906+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 17:43:30.926+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472ccb0 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 17:43:30.926+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472ccb0 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 17:43:30.946+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 17:43:30.956+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4481b180) will be pushed
07-15 17:43:30.956+0800 I/efl-extension( 4298): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44d2c3b0]'s widget[0x44d24570] to layout widget[0x4481b180]
07-15 17:43:30.961+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472ccb0 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 17:43:30.961+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472ccb0 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 17:43:30.961+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472ccb0 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 17:43:30.961+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472ccb0 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 17:43:30.961+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4472ccb0 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 17:43:30.961+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4472ccb0 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 17:43:30.971+0800 I/efl-extension( 4298): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 17:43:30.971+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x417e96f8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-15 17:43:31.011+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2796 _push_transition_cb() item(0x4481b180) will transition
07-15 17:43:31.426+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:1193 _on_item_push_finished() item(0x44506a20) transition finished
07-15 17:43:31.426+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:1218 _on_item_show_finished() item(0x4481b180) transition finished
07-15 17:43:31.521+0800 E/EFL     (  461): ecore_x<461> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1600002 time=1912695
07-15 17:43:31.526+0800 E/EFL     ( 4298): ecore_x<4298> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=1912695
07-15 17:43:31.526+0800 E/EFL     (  461): ecore_x<461> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=1912695
07-15 17:43:32.116+0800 E/EFL     ( 4298): ecore_x<4298> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1913832 button=1
07-15 17:43:32.221+0800 E/EFL     ( 4298): ecore_x<4298> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1913937 button=1
07-15 17:43:33.376+0800 I/APP_CORE(  810): appcore-efl.c: __do_app(453) > [APP 810] Event: MEM_FLUSH State: PAUSED
07-15 17:43:35.776+0800 E/WMS     (  520): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-15 17:43:36.226+0800 E/EFL     ( 4298): elementary<4298> elm_genlist.c:7001 elm_genlist_item_selected_set() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-15 17:43:36.326+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 17:43:36.326+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4481a158, elm_image, _activated_obj : 0x4472ea10, activated : 1
07-15 17:43:36.326+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 17:43:36.356+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d25598 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 17:43:36.356+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d25598 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 17:43:36.356+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 17:43:36.381+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44729da8) will be pushed
07-15 17:43:36.381+0800 I/efl-extension( 4298): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x447b9078]'s widget[0x44dd0e98] to layout widget[0x44729da8]
07-15 17:43:36.391+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d25598 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:36.391+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d25598 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:43:36.391+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d25598 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:36.391+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d25598 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:43:36.391+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d25598 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:36.391+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d25598 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:43:36.396+0800 I/efl-extension( 4298): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 17:43:36.446+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2796 _push_transition_cb() item(0x44729da8) will transition
07-15 17:43:36.861+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:1193 _on_item_push_finished() item(0x4481b180) transition finished
07-15 17:43:36.866+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:1218 _on_item_show_finished() item(0x44729da8) transition finished
07-15 17:43:36.991+0800 W/SHealthCommon( 1118): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1500076800000.000000[0;m
07-15 17:43:37.141+0800 W/SHealthCommon( 1118): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-15 17:43:37.186+0800 I/HealthDataService(  998): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-15 17:43:37.221+0800 I/healthData( 1118): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-15 17:43:45.841+0800 E/RESOURCED(  608): block-monitor.c: block_logging(123) > pid 4298(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/admin/2017-07-15-17--43-acc.txt
07-15 17:43:45.851+0800 E/RESOURCED(  608): block-monitor.c: block_logging(123) > pid 4298(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/admin/2017-07-15-17--43-gyr.txt
07-15 17:43:45.921+0800 E/EFL     ( 4298): elementary<4298> elm_genlist.c:7001 elm_genlist_item_selected_set() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-15 17:43:45.941+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 17:43:45.941+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44dd1478, elm_image, _activated_obj : 0x4481a158, activated : 1
07-15 17:43:45.941+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 17:43:45.961+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dd1d48 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 17:43:45.961+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dd1d48 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 17:43:45.961+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 17:43:45.981+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44de7878) will be pushed
07-15 17:43:45.981+0800 I/efl-extension( 4298): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44de1c38]'s widget[0x44de26d8] to layout widget[0x44de7878]
07-15 17:43:45.991+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dd1d48 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:45.991+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dd1d48 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:43:45.996+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dd1d48 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:45.996+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dd1d48 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:43:45.996+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dd1d48 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:45.996+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dd1d48 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:43:46.006+0800 I/efl-extension( 4298): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 17:43:46.036+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2796 _push_transition_cb() item(0x44de7878) will transition
07-15 17:43:46.251+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:3136 elm_naviframe_item_pop() naviframe item pop
07-15 17:43:46.251+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:3149 elm_naviframe_item_pop() item(0x44de7878) will be popped.
07-15 17:43:46.251+0800 E/EFL     ( 4298): elementary<4298> elm_genlist.c:7001 elm_genlist_item_selected_set() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-15 17:43:46.256+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 17:43:46.256+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44de52e8, elm_image, _activated_obj : 0x44dd1478, activated : 1
07-15 17:43:46.256+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 17:43:46.261+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44de3588 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 17:43:46.261+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44de3588 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 17:43:46.261+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 17:43:46.266+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44e08c20) will be pushed
07-15 17:43:46.266+0800 I/efl-extension( 4298): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44fdf1a0]'s widget[0x44fdc588] to layout widget[0x44e08c20]
07-15 17:43:46.266+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44de3588 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:46.266+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44de3588 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:43:46.271+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44de3588 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:46.271+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44de3588 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:43:46.271+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44de3588 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:46.271+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44de3588 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 17:43:46.271+0800 I/efl-extension( 4298): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 17:43:46.311+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2280 _pop_transition_cb() item(0x44de7878) will transition
07-15 17:43:46.311+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:2796 _push_transition_cb() item(0x44e08c20) will transition
07-15 17:43:46.736+0800 E/EFL     ( 4298): elementary<4298> elc_naviframe.c:1274 _on_item_pop_finished() item(0x44de7878) transition finished
07-15 17:43:46.736+0800 I/efl-extension( 4298): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x44dd1d48, obj: 0x44dd1d48
07-15 17:43:46.736+0800 I/efl-extension( 4298): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-15 17:43:46.736+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-15 17:43:46.736+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44dd1d48, elm_scroller, func : 0x418fb351
07-15 17:43:46.736+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-15 17:43:46.736+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-15 17:43:46.736+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44dd1478, elm_image, func : 0x418fb351
07-15 17:43:46.736+0800 I/efl-extension( 4298): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-15 17:43:46.736+0800 I/efl-extension( 4298): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0x44dd1d48 : elm_scroller] rotary callabck is deleted
07-15 17:43:46.741+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dd1d48 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 17:43:46.741+0800 E/EFL     ( 4298): elementary<4298> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dd1d48 : elm_scroller] cw(0), ch(0), pw(260), ph(360)
07-15 17:43:47.081+0800 W/CRASH_MANAGER( 4422): worker.c: worker_job(1205) > 110429873656e150011182
