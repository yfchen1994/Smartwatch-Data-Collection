S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 19297
Date: 2017-07-12 18:08:29+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 19297, uid 5000)

Register Information
r0   = 0x41ee6198, r1   = 0x00000001
r2   = 0x4399cf58, r3   = 0x000003fd
r4   = 0x00000008, r5   = 0xffffffff
r6   = 0x41ee61a0, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x00000001
r10  = 0x4004e7e8, fp   = 0x4031116c
ip   = 0x400a9188, sp   = 0xbefaecd0
lr   = 0x403ce579, pc   = 0x403ce6b2
cpsr = 0x80000030

Memory Information
MemTotal:   491132 KB
MemFree:     44180 KB
Buffers:     16568 KB
Cached:     120488 KB
VmPeak:     109068 KB
VmSize:     107032 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24232 KB
VmRSS:       24228 KB
VmData:      43496 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 19297 TID = 19297
19297 19387 19425 19426 19427 

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
41d66000 41d71000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41d7a000 41d7f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41d87000 41d9e000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
41dab000 41dad000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41db5000 41db6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
41dd0000 41dd1000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
41de1000 41df5000 rw-p [heap]
41df5000 41f29000 rw-p [heap]
437c2000 4388c000 r-xp /usr/lib/libCOREGL.so.4.0
43cf3000 444f2000 rw-p [stack:19387]
444f2000 444fa000 r-xp /usr/lib/libfeedback.so.0.1.4
44b0b000 44b0c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44b14000 44b16000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44b1e000 44b29000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44b31000 44b38000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44b40000 44b58000 r-xp /usr/lib/libmmfsound.so.0.1.0
44b69000 44b6d000 r-xp /usr/lib/libmmfsession.so.0.0.0
44b76000 44b81000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44b8e000 44b92000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44b9a000 44bb0000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44bb8000 44c19000 r-xp /usr/lib/libasound.so.2.0.0
44c23000 44c26000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44c2e000 44c66000 r-xp /usr/lib/libpulse.so.0.16.2
44c67000 44c6a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44c72000 44cba000 r-xp /usr/lib/libmdm.so.1.2.62
44cbb000 44cbe000 r-xp /usr/lib/libtinycompress.so.0.0.0
44cc6000 44ccb000 r-xp /usr/lib/libjson.so.0.0.1
44cd3000 44d1c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44d25000 44d6c000 r-xp /usr/lib/libsndfile.so.1.0.26
44d78000 44d87000 r-xp /usr/lib/libmdm-common.so.1.1.22
44d90000 44db2000 r-xp /usr/lib/libvorbis.so.0.4.3
44dba000 44dbe000 r-xp /usr/lib/libogg.so.0.7.1
450c7000 458c6000 rw-p [stack:19425]
458c7000 460c6000 rw-p [stack:19426]
460c7000 46a52000 rw-p [stack:19427]
bef8f000 befb0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19297)
Call Stack Count: 13
 0: g_slice_alloc + 0x149 (0x403ce6b2) [/usr/lib/libglib-2.0.so.0] + 0x466b2
 1: g_mutex_new + 0x8 (0x4039e301) [/usr/lib/libglib-2.0.so.0] + 0x16301
 2: g_static_mutex_get_mutex_impl + 0x30 (0x4039e4f9) [/usr/lib/libglib-2.0.so.0] + 0x164f9
 3: (0x403029a1) [/usr/lib/libecore.so.1] + 0x109a1
 4: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
 5: (0x402fe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
 6: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
 7: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 8: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 9: main + 0x11a (0x413c00e3) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x20e3
10: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
11: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
12: _single_line_entry_cb + 0x8b (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
ckage install complete
07-12 18:07:35.111+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-12 18:07:35.111+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-12 18:07:35.111+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_package_install_event(5061) > triggered from Gear itself.
07-12 18:07:35.126+0800 E/PKGMGR_INFO(  520): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-12 18:07:35.171+0800 E/STARTER (  754): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
07-12 18:07:35.181+0800 E/WMS     (  521): wms_db.c: wms_db_package_event_insert_record(190) > 
07-12 18:07:35.186+0800 E/PKGMGR_INFO(19287): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
07-12 18:07:35.201+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2887) > send_install_response completed : END
07-12 18:07:35.211+0800 E/PKGMGR_OBSERVER(19287): pkg_observer.c: main(620) > OBSERVER end
07-12 18:07:35.221+0800 E/PKGMGR_SERVER(19285): pkgmgr-server.c: sighandler(486) > child NORMAL exit [19287]
07-12 18:07:35.256+0800 W/APPS    (  811): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
07-12 18:07:35.566+0800 E/PKGMGR_SERVER(19285): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-12 18:07:36.076+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.086+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.086+0800 E/AUL     (19296): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 18:07:36.086+0800 E/AUL     (19296): aul_path.c: __get_path(169) > root_path is NULL!
07-12 18:07:36.106+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.116+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.116+0800 E/AUL     (19296): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 18:07:36.116+0800 E/AUL     (19296): aul_path.c: __get_path(169) > root_path is NULL!
07-12 18:07:36.131+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.146+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.146+0800 E/AUL     (19296): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 18:07:36.146+0800 E/AUL     (19296): aul_path.c: __get_path(169) > root_path is NULL!
07-12 18:07:36.156+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.166+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.166+0800 E/AUL     (19296): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 18:07:36.166+0800 E/AUL     (19296): aul_path.c: __get_path(169) > root_path is NULL!
07-12 18:07:36.191+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.201+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.201+0800 E/AUL     (19296): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 18:07:36.201+0800 E/AUL     (19296): aul_path.c: __get_path(169) > root_path is NULL!
07-12 18:07:36.216+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.226+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.226+0800 E/AUL     (19296): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 18:07:36.226+0800 E/AUL     (19296): aul_path.c: __get_path(169) > root_path is NULL!
07-12 18:07:36.241+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.256+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.256+0800 E/AUL     (19296): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 18:07:36.256+0800 E/AUL     (19296): aul_path.c: __get_path(169) > root_path is NULL!
07-12 18:07:36.266+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.281+0800 I/AUL     (19296): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:36.281+0800 E/AUL     (19296): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 18:07:36.281+0800 E/AUL     (19296): aul_path.c: __get_path(169) > root_path is NULL!
07-12 18:07:36.326+0800 I/UXT     (19296): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-12 18:07:36.491+0800 E/MALI    (19296): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-12 18:07:36.491+0800 E/MALI    (19296): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-12 18:07:36.491+0800 E/MALI    (19296): [gpu-ddk] devel/graphics_drv/r4p0
07-12 18:07:36.491+0800 E/MALI    (19296): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-12 18:07:36.491+0800 E/MALI    (19296): [coregl] devel/graphics_engine/master
07-12 18:07:36.491+0800 E/MALI    (19296): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-12 18:07:36.491+0800 E/MALI    (19296): ¼
07-12 18:07:37.241+0800 I/MALI    (19296): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-12 18:07:37.246+0800 E/MALI    (19296): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-12 18:07:37.261+0800 I/AUL     (19307): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-12 18:07:37.311+0800 I/AUL     (19307): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 18:07:37.311+0800 E/AUL     (19307): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 18:07:37.311+0800 E/AUL     (19307): aul_path.c: __get_path(169) > root_path is NULL!
07-12 18:07:37.566+0800 E/PKGMGR_SERVER(19285): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-12 18:07:38.291+0800 E/rpm-installer(19286): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-12 18:07:38.291+0800 E/rpm-installer(19286): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-12 18:07:38.291+0800 E/rpm-installer(19286): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-12 18:07:38.301+0800 E/PKGMGR_SERVER(19285): pkgmgr-server.c: sighandler(486) > child NORMAL exit [19286]
07-12 18:07:38.371+0800 E/RESOURCED(  600): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/19286/oom_score_adj failed
07-12 18:07:38.371+0800 E/RESOURCED(  600): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 19286
07-12 18:07:39.566+0800 E/PKGMGR_SERVER(19285): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-12 18:07:39.566+0800 E/PKGMGR_SERVER(19285): pkgmgr-server.c: main(2296) > package manager server terminated.
07-12 18:07:40.051+0800 W/AUL     (19373): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-12 18:07:40.056+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 0
07-12 18:07:40.091+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-12 18:07:40.116+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-12 18:07:40.116+0800 E/AUL_AMD (  524): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-12 18:07:40.116+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(1782) > caller pid : 19373
07-12 18:07:40.136+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(2218) > pad pid(-5)
07-12 18:07:40.136+0800 E/RESOURCED(  600): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 4
07-12 18:07:40.141+0800 W/AUL_PAD ( 1308): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-12 18:07:40.141+0800 W/AUL_PAD ( 1308): launchpad.c: __send_result_to_caller(272) > Check app launching
07-12 18:07:40.141+0800 W/AUL_PAD (19297): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-12 18:07:40.146+0800 W/AUL_PAD (19297): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-12 18:07:40.146+0800 W/AUL_PAD (19297): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-12 18:07:40.146+0800 W/AUL_PAD (19297): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-12 18:07:40.246+0800 I/efl-extension(19297): efl_extension.c: eext_mod_init(40) > Init
07-12 18:07:40.256+0800 I/UXT     (19297): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-12 18:07:40.276+0800 W/AUL_PAD (19297): launchpad_loader.c: main(690) > [candidate] dlsym
07-12 18:07:40.276+0800 W/AUL_PAD (19297): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-12 18:07:40.281+0800 I/CAPI_APPFW_APPLICATION(19297): app_main.c: ui_app_main(704) > app_efl_main
07-12 18:07:40.286+0800 I/CAPI_APPFW_APPLICATION(19297): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-12 18:07:40.341+0800 W/AUL     (  524): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(19297) type(uiapp) bg(0)
07-12 18:07:40.346+0800 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (19297) was created
07-12 18:07:40.346+0800 W/AUL     (19373): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19297)
07-12 18:07:40.351+0800 W/STARTER (  754): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19297]
07-12 18:07:40.511+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 18:07:40.511+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-12 18:07:40.511+0800 I/efl-extension(19297): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-12 18:07:40.511+0800 I/efl-extension(19297): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-12 18:07:40.511+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x438b2d60, elm_image, _activated_obj : 0x0, activated : 1
07-12 18:07:40.511+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 18:07:40.516+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x438b31c8) will be pushed
07-12 18:07:40.521+0800 I/efl-extension(19297): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x438ec580]'s widget[0x438b4658] to layout widget[0x438b31c8]
07-12 18:07:40.521+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x438a2910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 18:07:40.521+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x438a2910 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-12 18:07:40.521+0800 I/efl-extension(19297): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 18:07:40.531+0800 I/APP_CORE(19297): appcore-efl.c: __do_app(453) > [APP 19297] Event: RESET State: CREATED
07-12 18:07:40.531+0800 I/CAPI_APPFW_APPLICATION(19297): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-12 18:07:40.551+0800 I/APP_CORE(19297): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-12 18:07:40.551+0800 I/APP_CORE(19297): appcore-efl.c: __do_app(524) > [APP 19297] Initial Launching, call the resume_cb
07-12 18:07:40.551+0800 I/CAPI_APPFW_APPLICATION(19297): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-12 18:07:40.576+0800 W/W_HOME  (  811): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-12 18:07:40.576+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 18:07:40.576+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 18:07:40.576+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 18:07:40.576+0800 W/W_HOME  (  811): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-12 18:07:40.576+0800 W/W_HOME  (  811): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-12 18:07:40.576+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 18:07:40.576+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 18:07:40.581+0800 W/APP_CORE(19297): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400002
07-12 18:07:40.591+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x438a2910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 18:07:40.591+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x438a2910 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-12 18:07:40.636+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x438a2910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-12 18:07:40.636+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x438a2910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-12 18:07:40.726+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-12 18:07:40.726+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-12 18:07:40.726+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 18:07:40.726+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 18:07:40.726+0800 W/W_HOME  (  811): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-12 18:07:40.726+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: PAUSE State: RUNNING
07-12 18:07:40.726+0800 I/CAPI_APPFW_APPLICATION(  811): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-12 18:07:40.726+0800 W/W_HOME  (  811): main.c: _appcore_pause_cb(487) > appcore pause
07-12 18:07:40.726+0800 W/W_HOME  (  811): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-12 18:07:40.726+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 18:07:40.731+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 18:07:40.731+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 18:07:40.731+0800 W/W_HOME  (  811): rotary.c: rotary_deattach(156) > rotary_deattach:0x474c2038
07-12 18:07:40.731+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-12 18:07:40.731+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x474c2038, elm_layout, func : 0x4005653d
07-12 18:07:40.731+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-12 18:07:40.731+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-12 18:07:40.731+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-12 18:07:40.731+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e39b0, elm_box, _activated_obj : 0x474c2038, activated : 1
07-12 18:07:40.731+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 18:07:40.731+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 18:07:40.731+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-12 18:07:40.736+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 18:07:40.736+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 18:07:40.736+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(811) status(bg) type(uiapp)
07-12 18:07:40.736+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[811] goes to (4)
07-12 18:07:40.736+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 811)'s state(4)
07-12 18:07:40.741+0800 W/W_HOME  (  811): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-12 18:07:40.741+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 18:07:40.741+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 18:07:40.741+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 18:07:40.741+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-12 18:07:40.741+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-12 18:07:40.741+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 18:07:40.741+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 18:07:40.741+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 18:07:40.746+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 18:07:40.746+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 18:07:40.746+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 18:07:40.746+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-12 18:07:40.746+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-12 18:07:40.746+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 18:07:40.746+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 18:07:40.746+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-12 18:07:40.746+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-12 18:07:40.746+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 18:07:40.746+0800 E/CAPI_APPFW_APP_CONTROL( 1005): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-12 18:07:40.746+0800 W/MUSIC_CONTROL_SERVICE( 1005): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1005]   [com.samsung.w-home]register msg port [false][0m
07-12 18:07:40.751+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-12 18:07:40.751+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 18:07:40.751+0800 W/wnotib  (  811): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [1], notiboard card appending count [1].
07-12 18:07:40.761+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[19297] goes to (3)
07-12 18:07:40.761+0800 W/AUL_AMD (  524): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-12 18:07:40.761+0800 W/AUL_AMD (  524): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-12 18:07:40.761+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(19297) status(fg) type(uiapp)
07-12 18:07:40.791+0800 I/APP_CORE(19297): appcore-efl.c: __do_app(453) > [APP 19297] Event: RESUME State: RUNNING
07-12 18:07:40.806+0800 W/APPS    (  811): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-12 18:07:41.116+0800 E/AUL     (  524): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-12 18:07:41.246+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 18:07:41.491+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 18:07:41.501+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19297
07-12 18:07:41.501+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 18:07:41.526+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 18:07:41.536+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19297
07-12 18:07:41.536+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 18:07:41.726+0800 I/AUL_PAD (19376): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-12 18:07:45.756+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 18:07:48.596+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 18:07:50.581+0800 E/EFL     (19297): ecore_x<19297> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=27597012 button=1
07-12 18:07:50.581+0800 E/EFL     (19297): ecore_x<19297> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=27597013 button=1
07-12 18:07:50.581+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x438a2910 : elm_genlist] mouse move
07-12 18:07:50.581+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x438a2910 : elm_genlist] mouse move
07-12 18:07:50.581+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x438a2910 : elm_genlist] hold(0), freeze(0)
07-12 18:07:50.586+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x438a2910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-12 18:07:50.586+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x438a2910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-12 18:07:50.586+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x438a2910 : elm_genlist] x(0), y(130)
07-12 18:07:50.586+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x438a2910 : elm_genlist] t_in(0.300000), pos_x(0)
07-12 18:07:50.586+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x438a2910 : elm_genlist] t_in(0.300000), pos_y(130)
07-12 18:07:50.591+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x438a2910 : elm_genlist] time(0.066018)
07-12 18:07:50.591+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x438a2910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-12 18:07:50.591+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x438a2910 : elm_genlist] time(0.066018)
07-12 18:07:50.591+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x438a2910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(8)
07-12 18:07:50.861+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x438a2910 : elm_genlist] time(0.254878)
07-12 18:07:50.866+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x438a2910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(8)
07-12 18:07:50.866+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x438a2910 : elm_genlist] time(0.254878)
07-12 18:07:50.866+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x438a2910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(33)
07-12 18:07:50.931+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x438a2910 : elm_genlist] time(0.970216)
07-12 18:07:50.931+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x438a2910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(33)
07-12 18:07:50.931+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x438a2910 : elm_genlist] time(0.970216)
07-12 18:07:50.936+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x438a2910 : elm_genlist] animation stop!!
07-12 18:07:50.966+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 18:07:50.966+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44840518, elm_image, _activated_obj : 0x438b2d60, activated : 1
07-12 18:07:50.966+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 18:07:50.986+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4483e7b8 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-12 18:07:50.986+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4483e7b8 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-12 18:07:51.001+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 18:07:51.011+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44dcb620) will be pushed
07-12 18:07:51.011+0800 I/efl-extension(19297): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44df0dd0]'s widget[0x44deb960] to layout widget[0x44dcb620]
07-12 18:07:51.011+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4483e7b8 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-12 18:07:51.011+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4483e7b8 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-12 18:07:51.011+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4483e7b8 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-12 18:07:51.011+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4483e7b8 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-12 18:07:51.016+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4483e7b8 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-12 18:07:51.016+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4483e7b8 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-12 18:07:51.021+0800 I/efl-extension(19297): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 18:07:51.021+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x438a2910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-12 18:07:51.061+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:2796 _push_transition_cb() item(0x44dcb620) will transition
07-12 18:07:51.476+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:1193 _on_item_push_finished() item(0x438b31c8) transition finished
07-12 18:07:51.476+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:1218 _on_item_show_finished() item(0x44dcb620) transition finished
07-12 18:07:51.581+0800 E/EFL     (  397): ecore_x<397> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3400002 time=27597466
07-12 18:07:51.581+0800 E/EFL     (19297): ecore_x<19297> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=27597466
07-12 18:07:51.581+0800 E/EFL     (  397): ecore_x<397> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=27597466
07-12 18:07:53.961+0800 W/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-12 18:07:53.961+0800 I/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-12 18:07:53.966+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 18:07:53.966+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 18:07:53.966+0800 I/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-12 18:07:53.966+0800 I/watchface-viewer(  901): viewer-data-provider.cpp: UpdateMoonPhase(4351) > Moon Position = 16.979159
07-12 18:07:53.986+0800 E/wnoti-service( 1046): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-12 18:07:53.986+0800 E/wnoti-service( 1046): wnoti-native-client.c: handle_cache_notification(737) > >>
07-12 18:07:54.001+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-12 18:07:54.006+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-12 18:07:54.006+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-12 18:07:54.006+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-12 18:07:54.011+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-12 18:07:54.011+0800 W/WECONN  (  506): <wc_manager_get_bearer_state:988> type : 1
07-12 18:07:54.061+0800 E/ALARM_MANAGER(  506): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(12-7-2017, 18:07:59), repeat(0), interval(0), type(-1073741822)
07-12 18:07:54.071+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [506].
07-12 18:07:54.106+0800 I/AUL     (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 18:07:54.106+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 15
07-12 18:07:54.126+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 18:07:54.146+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 18:07:54.146+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499854079, Wed Jul 12 18:07:59 2017
07-12 18:07:54.146+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 860440577, next duetime: 1499854079
07-12 18:07:54.146+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(860440577)
07-12 18:07:54.146+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499864348), due_time(1499854079)
07-12 18:07:54.161+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 18:07:54.166+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 18:07:54.166+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 10:07:59 (UTC).
07-12 18:07:54.166+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 18:07:54.166+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 18:07:54.176+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 18:07:54.176+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 18:07:54.186+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:385> }
07-12 18:07:54.186+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:531> }
07-12 18:07:54.191+0800 W/SHealthService( 1107): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-12 18:07:59.001+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
07-12 18:07:59.051+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 18:07:59.096+0800 W/AUL     (  518): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(506) type(wakeup)
07-12 18:07:59.106+0800 E/RESOURCED(  600): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 506
07-12 18:07:59.116+0800 E/ALARM_MANAGER(  506): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [860440577]
07-12 18:07:59.116+0800 W/WECONN  (  506): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
07-12 18:07:59.116+0800 W/WECONN  (  506): <wc_manager_get_bearer_state:988> type : 1
07-12 18:07:59.116+0800 W/WECONN  (  506): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
07-12 18:07:59.116+0800 W/WECONN  (  506): <__connect_for_auto_switch:1706> { device=0x42903930, device->bt_address=1E:F0
07-12 18:07:59.131+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_expired(1445) > alarm_id[860440577] is expired.
07-12 18:07:59.131+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 18:07:59.131+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(860440577)
07-12 18:07:59.131+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1591639436) is OVER.
07-12 18:07:59.131+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 18:07:59.131+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 12:59:08 (UTC).
07-12 18:07:59.131+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 18:07:59.131+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 18:07:59.131+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
07-12 18:07:59.161+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 18:07:59.271+0800 W/WECONN  (  506): <__connect_for_auto_switch:1719> }
07-12 18:07:59.271+0800 W/WECONN  (  506):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
07-12 18:07:59.271+0800 W/WECONN  (  506): <__wc_device_try_to_connect_on_wear:185> }
07-12 18:08:00.701+0800 W/APPS    (  811): apps_main.c: _time_changed_cb(308) >  date : 12->12
07-12 18:08:04.441+0800 W/WECONN  (  506): <__on_connect_socket:378> {
07-12 18:08:04.441+0800 W/WECONN  (  506): <__is_device_matched_to:2560> le : , br_edr : 1E:F0, identifier : 1E:F0
07-12 18:08:04.441+0800 W/WECONN  (  506): <__on_connect_socket:383> result(-29359863), state(0)
07-12 18:08:04.441+0800 W/WECONN  (  506): <__on_connect_socket:387> }
07-12 18:08:05.106+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 18:08:12.996+0800 E/EFL     (19297): ecore_x<19297> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=27619426 button=1
07-12 18:08:12.996+0800 E/EFL     (19297): ecore_x<19297> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=27619428 button=1
07-12 18:08:14.006+0800 E/EFL     (  397): ecore_x<397> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3400002 time=27619428
07-12 18:08:14.011+0800 E/EFL     (19297): ecore_x<19297> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=27619428
07-12 18:08:14.016+0800 E/EFL     (  397): ecore_x<397> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=27619428
07-12 18:08:15.041+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 18:08:15.096+0800 E/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-12 18:08:15.106+0800 W/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(359) > [1;40;33mOnNotWearingStop[0;m
07-12 18:08:15.221+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 18:08:15.246+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 18:08:15.266+0800 W/SHealthCommon( 1107): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499817600000.000000[0;m
07-12 18:08:15.296+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-12 18:08:15.296+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-12 18:08:15.306+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 18:08:15.326+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 18:08:16.301+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 18:08:26.591+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 19297(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/admin/2017-07-12-18-0-8-acc.txt
07-12 18:08:26.591+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 19297(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/admin/2017-07-12-18-0-8-gyr.txt
07-12 18:08:27.886+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 18:08:27.916+0800 W/KEYROUTER(  397): e_mod_main.c: DeliverDeviceKeyEvents(3157) > Deliver KeyPress. value=2669, window=0x3400002
07-12 18:08:27.921+0800 E/EFL     (19297): ecore_x<19297> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=27634328
07-12 18:08:28.086+0800 W/KEYROUTER(  397): e_mod_main.c: DeliverDeviceKeyEvents(3168) > Deliver KeyRelease. value=2669, window=0x3400002
07-12 18:08:28.091+0800 E/EFL     (19297): ecore_x<19297> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=27634515
07-12 18:08:28.091+0800 E/efl-extension(19297): efl_extension_events.c: _eext_key_grab_rect_key_up_cb(240) > key up called
07-12 18:08:28.091+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:3136 elm_naviframe_item_pop() naviframe item pop
07-12 18:08:28.091+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:3149 elm_naviframe_item_pop() item(0x44dcb620) will be popped.
07-12 18:08:28.106+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:2280 _pop_transition_cb() item(0x44dcb620) will transition
07-12 18:08:28.546+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:1218 _on_item_show_finished() item(0x438b31c8) transition finished
07-12 18:08:28.546+0800 E/EFL     (19297): elementary<19297> elc_naviframe.c:1274 _on_item_pop_finished() item(0x44dcb620) transition finished
07-12 18:08:28.551+0800 I/efl-extension(19297): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x4483e7b8, obj: 0x4483e7b8
07-12 18:08:28.551+0800 I/efl-extension(19297): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-12 18:08:28.551+0800 I/efl-extension(19297): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0x44840518
07-12 18:08:28.551+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-12 18:08:28.551+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4483e7b8, elm_scroller, func : 0x416fb351
07-12 18:08:28.551+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-12 18:08:28.551+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-12 18:08:28.551+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44840518, elm_image, func : 0x416fb351
07-12 18:08:28.551+0800 I/efl-extension(19297): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-12 18:08:28.551+0800 I/efl-extension(19297): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0x4483e7b8 : elm_scroller] rotary callabck is deleted
07-12 18:08:28.556+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4483e7b8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 18:08:28.556+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4483e7b8 : elm_scroller] cw(0), ch(0), pw(260), ph(360)
07-12 18:08:28.556+0800 I/efl-extension(19297): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-12 18:08:28.556+0800 I/efl-extension(19297): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x44df0dd0 is freed
07-12 18:08:29.581+0800 E/EFL     (19297): ecore_x<19297> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=27636016 button=1
07-12 18:08:29.586+0800 E/EFL     (19297): elementary<19297> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x438a2910 : elm_genlist] mouse move
07-12 18:08:29.976+0800 I/MALI    (  811): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-12 18:08:29.996+0800 W/CRASH_MANAGER(19447): worker.c: worker_job(1205) > 111929773656e149985410
