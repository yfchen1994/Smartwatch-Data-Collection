S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 6303
Date: 2017-07-12 11:49:44+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 6303, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000189f
r2   = 0x00000006, r3   = 0x0000189f
r4   = 0x00000006, r5   = 0x00000002
r6   = 0x405abbec, r7   = 0x0000010c
r8   = 0x00000038, r9   = 0x00000002
r10  = 0xbee310f8, fp   = 0xbee31710
ip   = 0x4138e030, sp   = 0xbee30fd8
lr   = 0x404ad328, pc   = 0x404a9668
cpsr = 0x20000010

Memory Information
MemTotal:   491132 KB
MemFree:     64680 KB
Buffers:     14316 KB
Cached:     129896 KB
VmPeak:     109128 KB
VmSize:     107092 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24168 KB
VmRSS:       24164 KB
VmData:      43556 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6303 TID = 6303
6303 6385 6409 6410 6411 

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
43c7f000 4457e000 rw-p [stack:6385]
4457e000 4457f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
448e7000 448e8000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44906000 4490e000 r-xp /usr/lib/libfeedback.so.0.1.4
44910000 44911000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44919000 4491b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44923000 4492e000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44936000 4493d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44945000 4495d000 r-xp /usr/lib/libmmfsound.so.0.1.0
4496e000 44972000 r-xp /usr/lib/libmmfsession.so.0.0.0
4497b000 44986000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44993000 44997000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
4499f000 449b5000 r-xp /usr/lib/libavsysaudio.so.0.0.1
449bd000 44a1e000 r-xp /usr/lib/libasound.so.2.0.0
44a28000 44a2b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44a33000 44a6b000 r-xp /usr/lib/libpulse.so.0.16.2
44a6c000 44a6f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44a77000 44abf000 r-xp /usr/lib/libmdm.so.1.2.62
44ac0000 44ac3000 r-xp /usr/lib/libtinycompress.so.0.0.0
44acb000 44ad0000 r-xp /usr/lib/libjson.so.0.0.1
44ad8000 44b21000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44b2a000 44b71000 r-xp /usr/lib/libsndfile.so.1.0.26
44b7d000 44b8c000 r-xp /usr/lib/libmdm-common.so.1.1.22
44b95000 44bb7000 r-xp /usr/lib/libvorbis.so.0.4.3
44bbf000 44bc3000 r-xp /usr/lib/libogg.so.0.7.1
450ff000 458fe000 rw-p [stack:6409]
458ff000 460fe000 rw-p [stack:6410]
460ff000 46a61000 rw-p [stack:6411]
bee12000 bee33000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6303)
Call Stack Count: 2
 0: gsignal + 0x3c (0x404a9668) [/lib/libc.so.6] + 0x2c668
 1: (0x1) (null)
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
loader.c: main(591) > [candidate] elm init, returned: 1
07-12 11:49:05.761+0800 E/MALI    ( 6304): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-12 11:49:05.761+0800 E/MALI    ( 6304): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-12 11:49:05.761+0800 E/MALI    ( 6304): [gpu-ddk] devel/graphics_drv/r4p0
07-12 11:49:05.761+0800 E/MALI    ( 6304): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-12 11:49:05.761+0800 E/MALI    ( 6304): [coregl] devel/graphics_engine/master
07-12 11:49:05.761+0800 E/MALI    ( 6304): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-12 11:49:05.761+0800 E/MALI    ( 6304): Ð
07-12 11:49:05.801+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:05.801+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:06.001+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:06.001+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:06.071+0800 E/PKGMGR_OBSERVER( 6293): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[62930002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[end] val[ok]
07-12 11:49:06.091+0800 W/W_HOME  (  811): clock_event.c: _pkgmgr_event_cb(247) > Pkg:org.example.sensordatacollection is updated, need to check validation
07-12 11:49:06.091+0800 W/W_HOME  (  811): clock_event.c: _pkgmgr_event_cb(251) > attacheck clock:com.samsung.watchface
07-12 11:49:06.106+0800 W/AUL_AMD (  524): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(end), value(ok)
07-12 11:49:06.141+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, COMPLETED]
07-12 11:49:06.141+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
07-12 11:49:06.141+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-12 11:49:06.141+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-12 11:49:06.141+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_package_install_event(5061) > triggered from Gear itself.
07-12 11:49:06.186+0800 E/PKGMGR_INFO( 6293): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
07-12 11:49:06.191+0800 E/STARTER (  754): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
07-12 11:49:06.201+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:06.201+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:06.221+0800 E/WMS     (  521): wms_db.c: wms_db_package_event_insert_record(190) > 
07-12 11:49:06.226+0800 E/PKGMGR_OBSERVER( 6293): pkg_observer.c: main(620) > OBSERVER end
07-12 11:49:06.236+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2887) > send_install_response completed : END
07-12 11:49:06.256+0800 E/PKGMGR_INFO(  520): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-12 11:49:06.261+0800 E/PKGMGR_SERVER( 6236): pkgmgr-server.c: sighandler(486) > child NORMAL exit [6293]
07-12 11:49:06.276+0800 W/APPS    (  811): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
07-12 11:49:06.396+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:06.396+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:06.566+0800 E/PKGMGR_SERVER( 6236): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-12 11:49:06.601+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:06.601+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:06.621+0800 W/MM_CAMCORDER( 6302): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
07-12 11:49:06.621+0800 W/MM_CAMCORDER( 6302): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
07-12 11:49:06.641+0800 I/efl-extension( 6302): efl_extension.c: eext_mod_init(40) > Init
07-12 11:49:06.796+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:06.796+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:07.001+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:07.001+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:07.201+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:07.201+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:07.396+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:07.396+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:07.601+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:07.601+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:07.741+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.756+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.756+0800 E/AUL     ( 6302): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 11:49:07.756+0800 E/AUL     ( 6302): aul_path.c: __get_path(169) > root_path is NULL!
07-12 11:49:07.771+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.781+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.781+0800 E/AUL     ( 6302): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 11:49:07.781+0800 E/AUL     ( 6302): aul_path.c: __get_path(169) > root_path is NULL!
07-12 11:49:07.796+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.796+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:07.801+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:07.811+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.811+0800 E/AUL     ( 6302): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 11:49:07.811+0800 E/AUL     ( 6302): aul_path.c: __get_path(169) > root_path is NULL!
07-12 11:49:07.836+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.861+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.861+0800 E/AUL     ( 6302): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 11:49:07.861+0800 E/AUL     ( 6302): aul_path.c: __get_path(169) > root_path is NULL!
07-12 11:49:07.876+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.891+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.891+0800 E/AUL     ( 6302): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 11:49:07.891+0800 E/AUL     ( 6302): aul_path.c: __get_path(169) > root_path is NULL!
07-12 11:49:07.906+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.916+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.916+0800 E/AUL     ( 6302): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 11:49:07.916+0800 E/AUL     ( 6302): aul_path.c: __get_path(169) > root_path is NULL!
07-12 11:49:07.931+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.946+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.946+0800 E/AUL     ( 6302): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 11:49:07.946+0800 E/AUL     ( 6302): aul_path.c: __get_path(169) > root_path is NULL!
07-12 11:49:07.961+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.971+0800 I/AUL     ( 6302): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:07.971+0800 E/AUL     ( 6302): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 11:49:07.971+0800 E/AUL     ( 6302): aul_path.c: __get_path(169) > root_path is NULL!
07-12 11:49:07.996+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:07.996+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:08.011+0800 I/UXT     ( 6302): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-12 11:49:08.196+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:08.196+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:08.276+0800 E/MALI    ( 6302): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-12 11:49:08.291+0800 E/MALI    ( 6302): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-12 11:49:08.291+0800 E/MALI    ( 6302): [gpu-ddk] devel/graphics_drv/r4p0
07-12 11:49:08.291+0800 E/MALI    ( 6302): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-12 11:49:08.291+0800 E/MALI    ( 6302): [coregl] devel/graphics_engine/master
07-12 11:49:08.291+0800 E/MALI    ( 6302): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-12 11:49:08.291+0800 E/MALI    ( 6302): CHKÑ©
07-12 11:49:08.401+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:08.401+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:08.566+0800 E/PKGMGR_SERVER( 6236): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-12 11:49:08.601+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:08.601+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:08.801+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:08.801+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:09.001+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:09.001+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:09.196+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:09.201+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:09.326+0800 E/rpm-installer( 6292): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-12 11:49:09.326+0800 E/rpm-installer( 6292): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-12 11:49:09.326+0800 E/rpm-installer( 6292): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-12 11:49:09.356+0800 E/PKGMGR_SERVER( 6236): pkgmgr-server.c: sighandler(486) > child NORMAL exit [6292]
07-12 11:49:09.356+0800 E/RESOURCED(  600): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/6292/oom_score_adj failed
07-12 11:49:09.356+0800 E/RESOURCED(  600): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 6292
07-12 11:49:09.401+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:09.401+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:09.441+0800 I/MALI    ( 6302): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-12 11:49:09.441+0800 E/MALI    ( 6302): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-12 11:49:09.461+0800 I/AUL     ( 6313): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-12 11:49:09.486+0800 I/AUL     ( 6313): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-12 11:49:09.486+0800 E/AUL     ( 6313): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-12 11:49:09.486+0800 E/AUL     ( 6313): aul_path.c: __get_path(169) > root_path is NULL!
07-12 11:49:09.601+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:09.601+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:09.801+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:09.801+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:10.006+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:10.006+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:10.201+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:10.201+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:10.401+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:10.401+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:10.566+0800 E/PKGMGR_SERVER( 6236): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-12 11:49:10.571+0800 E/PKGMGR_SERVER( 6236): pkgmgr-server.c: main(2296) > package manager server terminated.
07-12 11:49:10.606+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:10.606+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:10.801+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:10.801+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:11.001+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:11.001+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:11.201+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:11.201+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:11.356+0800 W/AUL     ( 6372): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-12 11:49:11.361+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 0
07-12 11:49:11.391+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-12 11:49:11.401+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:11.401+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:11.406+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-12 11:49:11.406+0800 E/AUL_AMD (  524): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-12 11:49:11.406+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(1782) > caller pid : 6372
07-12 11:49:11.426+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(2218) > pad pid(-5)
07-12 11:49:11.426+0800 E/RESOURCED(  600): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 1
07-12 11:49:11.426+0800 W/AUL_PAD ( 1308): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-12 11:49:11.426+0800 W/AUL_PAD ( 1308): launchpad.c: __send_result_to_caller(272) > Check app launching
07-12 11:49:11.426+0800 W/AUL_PAD ( 6303): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-12 11:49:11.431+0800 W/AUL_PAD ( 6303): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-12 11:49:11.431+0800 W/AUL_PAD ( 6303): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-12 11:49:11.431+0800 W/AUL_PAD ( 6303): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-12 11:49:11.511+0800 I/efl-extension( 6303): efl_extension.c: eext_mod_init(40) > Init
07-12 11:49:11.516+0800 I/UXT     ( 6303): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-12 11:49:11.536+0800 W/AUL_PAD ( 6303): launchpad_loader.c: main(690) > [candidate] dlsym
07-12 11:49:11.536+0800 W/AUL_PAD ( 6303): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-12 11:49:11.536+0800 I/CAPI_APPFW_APPLICATION( 6303): app_main.c: ui_app_main(704) > app_efl_main
07-12 11:49:11.541+0800 I/CAPI_APPFW_APPLICATION( 6303): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-12 11:49:11.596+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:11.596+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:11.626+0800 W/AUL     (  524): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(6303) type(uiapp) bg(0)
07-12 11:49:11.631+0800 W/AUL     ( 6372): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6303)
07-12 11:49:11.631+0800 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (6303) was created
07-12 11:49:11.631+0800 W/STARTER (  754): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6303]
07-12 11:49:11.766+0800 I/efl-extension( 6303): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 11:49:11.766+0800 I/efl-extension( 6303): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-12 11:49:11.766+0800 I/efl-extension( 6303): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-12 11:49:11.771+0800 I/efl-extension( 6303): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-12 11:49:11.771+0800 I/efl-extension( 6303): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4189fcb8, elm_image, _activated_obj : 0x0, activated : 1
07-12 11:49:11.771+0800 E/EFL     ( 6303): elementary<6303> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 11:49:11.781+0800 E/EFL     ( 6303): elementary<6303> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x418a0120) will be pushed
07-12 11:49:11.781+0800 I/efl-extension( 6303): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x4188f6e8]'s widget[0x418a15b0] to layout widget[0x418a0120]
07-12 11:49:11.781+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 11:49:11.781+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-12 11:49:11.786+0800 I/efl-extension( 6303): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 11:49:11.791+0800 I/APP_CORE( 6303): appcore-efl.c: __do_app(453) > [APP 6303] Event: RESET State: CREATED
07-12 11:49:11.791+0800 I/CAPI_APPFW_APPLICATION( 6303): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-12 11:49:11.801+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:11.801+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:11.816+0800 I/APP_CORE( 6303): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-12 11:49:11.816+0800 I/APP_CORE( 6303): appcore-efl.c: __do_app(524) > [APP 6303] Initial Launching, call the resume_cb
07-12 11:49:11.816+0800 I/CAPI_APPFW_APPLICATION( 6303): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-12 11:49:11.826+0800 W/W_HOME  (  811): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-12 11:49:11.826+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 11:49:11.826+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 11:49:11.826+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 11:49:11.826+0800 W/W_HOME  (  811): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-12 11:49:11.846+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 11:49:11.846+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 11:49:11.876+0800 W/APP_CORE( 6303): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1600002
07-12 11:49:11.876+0800 I/MALI    (  811): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-12 11:49:11.886+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 11:49:11.886+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-12 11:49:11.936+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-12 11:49:11.936+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-12 11:49:11.996+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:49:11.996+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:49:12.006+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-12 11:49:12.006+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-12 11:49:12.006+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 11:49:12.006+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 11:49:12.011+0800 W/W_HOME  (  811): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-12 11:49:12.011+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: PAUSE State: RUNNING
07-12 11:49:12.011+0800 I/CAPI_APPFW_APPLICATION(  811): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-12 11:49:12.011+0800 W/W_HOME  (  811): main.c: _appcore_pause_cb(487) > appcore pause
07-12 11:49:12.011+0800 W/W_HOME  (  811): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-12 11:49:12.011+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 11:49:12.011+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 11:49:12.011+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 11:49:12.016+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 11:49:12.016+0800 W/W_HOME  (  811): main.c: home_pause(546) > clock/widget paused
07-12 11:49:12.016+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-12 11:49:12.016+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 11:49:12.021+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 11:49:12.021+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-12 11:49:12.021+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-12 11:49:12.021+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 11:49:12.021+0800 E/CAPI_APPFW_APP_CONTROL( 1005): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-12 11:49:12.021+0800 W/MUSIC_CONTROL_SERVICE( 1005): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1005]   [com.samsung.w-home]register msg port [false][0m
07-12 11:49:12.021+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[811] goes to (4)
07-12 11:49:12.021+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 811)'s state(4)
07-12 11:49:12.021+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(811) status(bg) type(uiapp)
07-12 11:49:12.036+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-12 11:49:12.036+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 11:49:12.036+0800 W/wnotib  (  811): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-12 11:49:12.041+0800 W/WATCH_CORE(  901): appcore-watch.c: __widget_pause(1113) > widget_pause
07-12 11:49:12.041+0800 W/AUL     (  901): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(901) status(bg) type(watchapp)
07-12 11:49:12.041+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppPause(589) > 
07-12 11:49:12.056+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[6303] goes to (3)
07-12 11:49:12.061+0800 W/AUL_AMD (  524): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-12 11:49:12.061+0800 W/AUL_AMD (  524): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-12 11:49:12.061+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(6303) status(fg) type(uiapp)
07-12 11:49:12.091+0800 I/APP_CORE( 6303): appcore-efl.c: __do_app(453) > [APP 6303] Event: RESUME State: RUNNING
07-12 11:49:12.411+0800 E/AUL     (  524): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-12 11:49:12.526+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 11:49:12.836+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:49:12.846+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6303
07-12 11:49:12.851+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 11:49:12.861+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:49:12.871+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6303
07-12 11:49:12.876+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 11:49:13.091+0800 I/AUL_PAD ( 6374): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-12 11:49:16.916+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 11:49:17.031+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 11:49:19.651+0800 E/EFL     ( 6303): ecore_x<6303> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4886083 button=1
07-12 11:49:19.656+0800 E/EFL     ( 6303): ecore_x<6303> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4886087 button=1
07-12 11:49:19.656+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:19.656+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:19.656+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:19.656+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:19.656+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:19.666+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-12 11:49:19.666+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-12 11:49:19.666+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] x(0), y(130)
07-12 11:49:19.666+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x417e96d8 : elm_genlist] t_in(0.300000), pos_x(0)
07-12 11:49:19.666+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x417e96d8 : elm_genlist] t_in(0.300000), pos_y(130)
07-12 11:49:19.671+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.120734)
07-12 11:49:19.671+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-12 11:49:19.671+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.120734)
07-12 11:49:19.676+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(15)
07-12 11:49:19.956+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.999861)
07-12 11:49:19.956+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(15)
07-12 11:49:19.961+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.999861)
07-12 11:49:19.961+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] animation stop!!
07-12 11:49:19.961+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-12 11:49:20.046+0800 E/EFL     ( 6303): ecore_x<6303> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4886454 button=1
07-12 11:49:20.046+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.051+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.051+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.051+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.051+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.051+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] add hold animator
07-12 11:49:20.051+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] direction_x(0), direction_y(1)
07-12 11:49:20.051+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] drag_child_locked_y(0)
07-12 11:49:20.051+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] move content x(0), y(186)
07-12 11:49:20.096+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.096+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.096+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.096+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.096+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.096+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.096+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.096+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.096+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] direction_x(0), direction_y(1)
07-12 11:49:20.096+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] drag_child_locked_y(0)
07-12 11:49:20.096+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] move content x(0), y(305)
07-12 11:49:20.146+0800 E/EFL     ( 6303): ecore_x<6303> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4886541 button=1
07-12 11:49:20.146+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.146+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.921+0800 E/EFL     ( 6303): ecore_x<6303> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4887355 button=1
07-12 11:49:20.921+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.926+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.926+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.926+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.926+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.936+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.936+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.946+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.946+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.956+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.956+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.971+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-12 11:49:20.971+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-12 11:49:20.981+0800 E/EFL     ( 6303): ecore_x<6303> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4887412 button=1
07-12 11:49:21.056+0800 I/efl-extension( 6303): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 11:49:21.056+0800 I/efl-extension( 6303): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x444913b8, elm_image, _activated_obj : 0x4189fcb8, activated : 1
07-12 11:49:21.056+0800 I/efl-extension( 6303): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 11:49:21.081+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417c2708 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-12 11:49:21.081+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417c2708 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-12 11:49:21.106+0800 E/EFL     ( 6303): elementary<6303> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 11:49:21.116+0800 E/EFL     ( 6303): elementary<6303> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44740628) will be pushed
07-12 11:49:21.116+0800 I/efl-extension( 6303): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44e1ef90]'s widget[0x44e14fc8] to layout widget[0x44740628]
07-12 11:49:21.116+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417c2708 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:49:21.121+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417c2708 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:49:21.121+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417c2708 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:49:21.121+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417c2708 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:49:21.121+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417c2708 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:49:21.121+0800 E/EFL     ( 6303): elementary<6303> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417c2708 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:49:21.126+0800 I/efl-extension( 6303): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 11:49:21.156+0800 E/EFL     ( 6303): elementary<6303> elc_naviframe.c:2796 _push_transition_cb() item(0x44740628) will transition
07-12 11:49:21.571+0800 E/EFL     ( 6303): elementary<6303> elc_naviframe.c:1193 _on_item_push_finished() item(0x418a0120) transition finished
07-12 11:49:21.571+0800 E/EFL     ( 6303): elementary<6303> elc_naviframe.c:1218 _on_item_show_finished() item(0x44740628) transition finished
07-12 11:49:21.986+0800 E/EFL     (  397): ecore_x<397> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1600002 time=4887564
07-12 11:49:21.991+0800 E/EFL     ( 6303): ecore_x<6303> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=4887564
07-12 11:49:21.996+0800 E/EFL     (  397): ecore_x<397> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=4887564
07-12 11:49:25.591+0800 E/EFL     ( 6303): ecore_x<6303> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4892025 button=1
07-12 11:49:25.591+0800 E/EFL     ( 6303): ecore_x<6303> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4892027 button=1
07-12 11:49:28.291+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 11:49:44.261+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 6303(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/2017-07-12-11--49-acc.txt
07-12 11:49:44.261+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 6303(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/2017-07-12-11--49-gyr.txt
07-12 11:49:44.771+0800 W/CRASH_MANAGER( 6431): worker.c: worker_job(1205) > 060630373656e149983138
