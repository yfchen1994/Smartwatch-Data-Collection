S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 3479
Date: 2017-07-11 22:01:45+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3479, uid 5000)

Register Information
r0   = 0x0400d494, r1   = 0x445000b0
r2   = 0x00000170, r3   = 0x000001ff
r4   = 0x44500010, r5   = 0x444ee000
r6   = 0x44500040, r7   = 0x4453fe40
r8   = 0x0000270e, r9   = 0x00000098
r10  = 0x000001ff, fp   = 0x44500048
ip   = 0x04005494, sp   = 0xbef98c38
lr   = 0x404eeefc, pc   = 0x404ec4fc
cpsr = 0x80000010

Memory Information
MemTotal:   490112 KB
MemFree:      3924 KB
Buffers:     24308 KB
Cached:     146540 KB
VmPeak:     110416 KB
VmSize:     107864 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23724 KB
VmRSS:       23724 KB
VmData:      44328 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3479 TID = 3479
3479 3573 3590 3591 

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
43c7f000 4447e000 rw-p [stack:3573]
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
45012000 45811000 rw-p [stack:3590]
45812000 46011000 rw-p [stack:3591]
bef79000 bef9a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3479)
Call Stack Count: 1
 0: (0x404ec4fc) [/lib/libc.so.6] + 0x6f4fc
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
pkg observer info : req_id[34700002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[end] val[ok]
07-11 22:01:06.475+0800 W/AUL_AMD (  521): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(end), value(ok)
07-11 22:01:06.500+0800 W/W_HOME  (  824): clock_event.c: _pkgmgr_event_cb(247) > Pkg:org.example.sensordatacollection is updated, need to check validation
07-11 22:01:06.500+0800 W/W_HOME  (  824): clock_event.c: _pkgmgr_event_cb(251) > attacheck clock:com.samsung.watchface
07-11 22:01:06.510+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, COMPLETED]
07-11 22:01:06.510+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
07-11 22:01:06.510+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-11 22:01:06.510+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-11 22:01:06.510+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5061) > triggered from Gear itself.
07-11 22:01:06.550+0800 E/PKGMGR_INFO( 3470): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
07-11 22:01:06.565+0800 E/PKGMGR_OBSERVER( 3470): pkg_observer.c: main(620) > OBSERVER end
07-11 22:01:06.590+0800 E/STARTER (  762): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
07-11 22:01:06.590+0800 E/PKGMGR_SERVER( 3468): pkgmgr-server.c: sighandler(486) > child NORMAL exit [3470]
07-11 22:01:06.600+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:06.600+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:06.600+0800 E/WMS     (  519): wms_db.c: wms_db_package_event_insert_record(190) > 
07-11 22:01:06.600+0800 E/PKGMGR_INFO(  518): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-11 22:01:06.615+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2887) > send_install_response completed : END
07-11 22:01:06.650+0800 W/APPS    (  824): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
07-11 22:01:06.795+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:06.795+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:06.995+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:06.995+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:07.045+0800 E/PKGMGR_SERVER( 3468): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-11 22:01:07.195+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:07.195+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:07.395+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:07.395+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:07.595+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:07.595+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:07.795+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:07.795+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:07.935+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:07.970+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:07.980+0800 E/AUL     ( 3481): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 22:01:07.980+0800 E/AUL     ( 3481): aul_path.c: __get_path(169) > root_path is NULL!
07-11 22:01:07.995+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:07.995+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:08.010+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.030+0800 W/WATCH_CORE(  909): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
07-11 22:01:08.030+0800 I/WATCH_CORE(  909): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-11 22:01:08.030+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:08.030+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:08.035+0800 E/wnoti-service( 1055): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-11 22:01:08.035+0800 E/wnoti-service( 1055): wnoti-native-client.c: handle_cache_notification(737) > >>
07-11 22:01:08.040+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-11 22:01:08.040+0800 W/WECONN  (  505): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-11 22:01:08.040+0800 W/WECONN  (  505): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-11 22:01:08.040+0800 W/WECONN  (  505): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-11 22:01:08.040+0800 W/WECONN  (  505): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-11 22:01:08.040+0800 W/WECONN  (  505): <wc_manager_get_bearer_state:988> type : 1
07-11 22:01:08.055+0800 E/ALARM_MANAGER(  505): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(11-7-2017, 22:01:13), repeat(0), interval(0), type(-1073741822)
07-11 22:01:08.065+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [505].
07-11 22:01:08.080+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.085+0800 E/AUL     ( 3481): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 22:01:08.085+0800 E/AUL     ( 3481): aul_path.c: __get_path(169) > root_path is NULL!
07-11 22:01:08.100+0800 I/AUL     (  516): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-11 22:01:08.105+0800 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 15
07-11 22:01:08.120+0800 I/AUL_AMD (  521): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-11 22:01:08.130+0800 I/AUL_AMD (  521): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-11 22:01:08.130+0800 E/ALARM_MANAGER(  516): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499781673, Tue Jul 11 22:01:13 2017
07-11 22:01:08.130+0800 E/ALARM_MANAGER(  516): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1202817990, next duetime: 1499781673
07-11 22:01:08.130+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1202817990)
07-11 22:01:08.135+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499788748), due_time(1499781673)
07-11 22:01:08.145+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-11 22:01:08.150+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-11 22:01:08.150+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-7-2017, 14:01:13 (UTC).
07-11 22:01:08.150+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-11 22:01:08.160+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-11 22:01:08.180+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.180+0800 W/WECONN  (  505): <__wc_device_on_wear_onoff_changed_cb:385> }
07-11 22:01:08.180+0800 W/WECONN  (  505): <__wc_feature_wearonoff_monitor_cb:531> }
07-11 22:01:08.190+0800 W/SHealthService( 1120): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-11 22:01:08.195+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:08.195+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:08.205+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.205+0800 E/AUL     ( 3481): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 22:01:08.205+0800 E/AUL     ( 3481): aul_path.c: __get_path(169) > root_path is NULL!
07-11 22:01:08.220+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.245+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.245+0800 E/AUL     ( 3481): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 22:01:08.245+0800 E/AUL     ( 3481): aul_path.c: __get_path(169) > root_path is NULL!
07-11 22:01:08.265+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.280+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.280+0800 E/AUL     ( 3481): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 22:01:08.285+0800 E/AUL     ( 3481): aul_path.c: __get_path(169) > root_path is NULL!
07-11 22:01:08.295+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.310+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.310+0800 E/AUL     ( 3481): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 22:01:08.310+0800 E/AUL     ( 3481): aul_path.c: __get_path(169) > root_path is NULL!
07-11 22:01:08.325+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.340+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.340+0800 E/AUL     ( 3481): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 22:01:08.340+0800 E/AUL     ( 3481): aul_path.c: __get_path(169) > root_path is NULL!
07-11 22:01:08.355+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.365+0800 I/AUL     ( 3481): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:08.365+0800 E/AUL     ( 3481): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 22:01:08.365+0800 E/AUL     ( 3481): aul_path.c: __get_path(169) > root_path is NULL!
07-11 22:01:08.395+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:08.395+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:08.405+0800 I/UXT     ( 3481): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-11 22:01:08.600+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:08.600+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:08.605+0800 E/MALI    ( 3481): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-11 22:01:08.605+0800 E/MALI    ( 3481): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-11 22:01:08.605+0800 E/MALI    ( 3481): [gpu-ddk] devel/graphics_drv/r4p0
07-11 22:01:08.605+0800 E/MALI    ( 3481): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-11 22:01:08.605+0800 E/MALI    ( 3481): [coregl] devel/graphics_engine/master
07-11 22:01:08.605+0800 E/MALI    ( 3481): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-11 22:01:08.605+0800 E/MALI    ( 3481): 
07-11 22:01:08.795+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:08.795+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:09.000+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:09.000+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:09.050+0800 E/PKGMGR_SERVER( 3468): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-11 22:01:09.195+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:09.195+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:09.270+0800 E/rpm-installer( 3469): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-11 22:01:09.270+0800 E/rpm-installer( 3469): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-11 22:01:09.270+0800 E/rpm-installer( 3469): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-11 22:01:09.285+0800 E/PKGMGR_SERVER( 3468): pkgmgr-server.c: sighandler(486) > child NORMAL exit [3469]
07-11 22:01:09.380+0800 E/RESOURCED(  628): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/3469/oom_score_adj failed
07-11 22:01:09.380+0800 E/RESOURCED(  628): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 3469
07-11 22:01:09.395+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:09.395+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:09.595+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:09.595+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:09.750+0800 I/MALI    ( 3481): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-11 22:01:09.750+0800 E/MALI    ( 3481): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-11 22:01:09.770+0800 I/AUL     ( 3490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-11 22:01:09.795+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:09.795+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:09.800+0800 I/AUL     ( 3490): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-11 22:01:09.800+0800 E/AUL     ( 3490): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-11 22:01:09.800+0800 E/AUL     ( 3490): aul_path.c: __get_path(169) > root_path is NULL!
07-11 22:01:10.000+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:10.000+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:10.210+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:10.210+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:10.395+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:10.395+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:10.600+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:10.600+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:10.800+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:10.800+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:10.910+0800 W/AUL     ( 3552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-11 22:01:10.915+0800 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 0
07-11 22:01:10.940+0800 I/AUL_AMD (  521): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-11 22:01:10.960+0800 I/AUL_AMD (  521): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-11 22:01:10.960+0800 E/AUL_AMD (  521): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-11 22:01:10.960+0800 W/AUL_AMD (  521): amd_launch.c: _start_app(1782) > caller pid : 3552
07-11 22:01:10.975+0800 E/RESOURCED(  628): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 2
07-11 22:01:10.975+0800 W/AUL_AMD (  521): amd_launch.c: _start_app(2218) > pad pid(-5)
07-11 22:01:10.975+0800 W/AUL_PAD ( 1330): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-11 22:01:10.980+0800 W/AUL_PAD ( 1330): launchpad.c: __send_result_to_caller(272) > Check app launching
07-11 22:01:10.980+0800 W/AUL_PAD ( 3479): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-11 22:01:10.980+0800 W/AUL_PAD ( 3479): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-11 22:01:10.980+0800 W/AUL_PAD ( 3479): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-11 22:01:10.980+0800 W/AUL_PAD ( 3479): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-11 22:01:10.995+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:10.995+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:11.045+0800 E/PKGMGR_SERVER( 3468): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-11 22:01:11.045+0800 E/PKGMGR_SERVER( 3468): pkgmgr-server.c: main(2296) > package manager server terminated.
07-11 22:01:11.060+0800 I/efl-extension( 3479): efl_extension.c: eext_mod_init(40) > Init
07-11 22:01:11.075+0800 I/UXT     ( 3479): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-11 22:01:11.100+0800 W/AUL_PAD ( 3479): launchpad_loader.c: main(690) > [candidate] dlsym
07-11 22:01:11.100+0800 W/AUL_PAD ( 3479): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-11 22:01:11.100+0800 I/CAPI_APPFW_APPLICATION( 3479): app_main.c: ui_app_main(704) > app_efl_main
07-11 22:01:11.110+0800 I/CAPI_APPFW_APPLICATION( 3479): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-11 22:01:11.180+0800 W/AUL     (  521): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(3479) type(uiapp) bg(0)
07-11 22:01:11.180+0800 W/AUL     ( 3552): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3479)
07-11 22:01:11.180+0800 W/AUL_AMD (  521): amd_status.c: __socket_monitor_cb(1277) > (3479) was created
07-11 22:01:11.185+0800 W/STARTER (  762): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [3479]
07-11 22:01:11.200+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:11.200+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:11.340+0800 I/efl-extension( 3479): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 22:01:11.340+0800 I/efl-extension( 3479): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-11 22:01:11.340+0800 I/efl-extension( 3479): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-11 22:01:11.340+0800 I/efl-extension( 3479): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-11 22:01:11.340+0800 I/efl-extension( 3479): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445074d8, elm_image, _activated_obj : 0x0, activated : 1
07-11 22:01:11.345+0800 E/EFL     ( 3479): elementary<3479> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 22:01:11.350+0800 E/EFL     ( 3479): elementary<3479> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44507940) will be pushed
07-11 22:01:11.350+0800 I/efl-extension( 3479): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x418833c8]'s widget[0x44508dd0] to layout widget[0x44507940]
07-11 22:01:11.355+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 22:01:11.355+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-11 22:01:11.355+0800 I/efl-extension( 3479): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 22:01:11.360+0800 I/APP_CORE( 3479): appcore-efl.c: __do_app(453) > [APP 3479] Event: RESET State: CREATED
07-11 22:01:11.360+0800 I/CAPI_APPFW_APPLICATION( 3479): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-11 22:01:11.380+0800 I/APP_CORE( 3479): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-11 22:01:11.380+0800 I/APP_CORE( 3479): appcore-efl.c: __do_app(524) > [APP 3479] Initial Launching, call the resume_cb
07-11 22:01:11.380+0800 I/CAPI_APPFW_APPLICATION( 3479): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-11 22:01:11.390+0800 W/APP_CORE( 3479): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400002
07-11 22:01:11.395+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:11.395+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:11.400+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 22:01:11.400+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-11 22:01:11.400+0800 W/W_HOME  (  824): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-11 22:01:11.400+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 22:01:11.400+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 22:01:11.400+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 22:01:11.400+0800 W/W_HOME  (  824): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-11 22:01:11.405+0800 W/W_INDICATOR(  763): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-11 22:01:11.405+0800 W/W_INDICATOR(  763): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-11 22:01:11.440+0800 I/MALI    (  824): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf650] swap changed from sync to async
07-11 22:01:11.480+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-11 22:01:11.480+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-11 22:01:11.570+0800 W/W_HOME  (  824): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-11 22:01:11.570+0800 W/W_HOME  (  824): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-11 22:01:11.570+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 22:01:11.570+0800 W/W_HOME  (  824): event_manager.c: _state_control(326) > appcore paused manually
07-11 22:01:11.570+0800 W/W_HOME  (  824): main.c: home_appcore_pause(514) > Home Appcore Paused
07-11 22:01:11.570+0800 I/APP_CORE( 3479): appcore-efl.c: __do_app(453) > [APP 3479] Event: RESUME State: RUNNING
07-11 22:01:11.570+0800 W/W_HOME  (  824): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-11 22:01:11.570+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 22:01:11.575+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 22:01:11.575+0800 W/W_INDICATOR(  763): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-11 22:01:11.580+0800 W/W_HOME  (  824): main.c: home_pause(546) > clock/widget paused
07-11 22:01:11.580+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 22:01:11.580+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-11 22:01:11.580+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-11 22:01:11.580+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-11 22:01:11.580+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-11 22:01:11.580+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-11 22:01:11.580+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-11 22:01:11.580+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-11 22:01:11.580+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-11 22:01:11.580+0800 W/STARTER (  762): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[824] goes to (4)
07-11 22:01:11.580+0800 E/STARTER (  762): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 824)'s state(4)
07-11 22:01:11.580+0800 W/AUL     (  521): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(824) status(bg) type(uiapp)
07-11 22:01:11.585+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-11 22:01:11.585+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-11 22:01:11.585+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-11 22:01:11.585+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-11 22:01:11.585+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-11 22:01:11.585+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-11 22:01:11.585+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-11 22:01:11.585+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-11 22:01:11.585+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-11 22:01:11.585+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-11 22:01:11.585+0800 E/CAPI_APPFW_APP_CONTROL( 1023): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-11 22:01:11.585+0800 W/MUSIC_CONTROL_SERVICE( 1023): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1023]   [com.samsung.w-home]register msg port [false][0m
07-11 22:01:11.590+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-11 22:01:11.595+0800 W/W_HOME  (  824): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-11 22:01:11.595+0800 I/CAPI_WATCH_APPLICATION(  909): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-11 22:01:11.595+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppTimeTick(616) > 
07-11 22:01:11.605+0800 I/APP_CORE(  824): appcore-efl.c: __do_app(453) > [APP 824] Event: PAUSE State: RUNNING
07-11 22:01:11.605+0800 I/CAPI_APPFW_APPLICATION(  824): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-11 22:01:11.605+0800 W/W_HOME  (  824): main.c: _appcore_pause_cb(487) > appcore pause
07-11 22:01:11.605+0800 E/W_HOME  (  824): main.c: _pause_cb(465) > paused already
07-11 22:01:11.605+0800 I/wnotib  (  824): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-11 22:01:11.605+0800 E/wnotib  (  824): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-11 22:01:11.610+0800 W/wnotib  (  824): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-11 22:01:11.620+0800 W/STARTER (  762): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[3479] goes to (3)
07-11 22:01:11.625+0800 W/AUL_AMD (  521): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-11 22:01:11.625+0800 W/AUL_AMD (  521): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-11 22:01:11.625+0800 W/AUL     (  521): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(3479) status(fg) type(uiapp)
07-11 22:01:11.635+0800 W/W_INDICATOR(  763): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-11 22:01:11.665+0800 W/WATCH_CORE(  909): appcore-watch.c: __widget_pause(1113) > widget_pause
07-11 22:01:11.665+0800 W/AUL     (  909): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(909) status(bg) type(watchapp)
07-11 22:01:11.665+0800 E/watchface-loader(  909): watchface-loader.cpp: OnAppPause(589) > 
07-11 22:01:11.975+0800 E/AUL     (  521): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-11 22:01:12.095+0800 I/APP_CORE(  824): appcore-efl.c: __do_app(453) > [APP 824] Event: MEM_FLUSH State: PAUSED
07-11 22:01:12.415+0800 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 22:01:12.425+0800 W/AUL_AMD (  521): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 3479
07-11 22:01:12.425+0800 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 22:01:12.450+0800 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 22:01:12.460+0800 W/AUL_AMD (  521): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 3479
07-11 22:01:12.460+0800 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 22:01:12.670+0800 I/AUL_PAD ( 3554): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-11 22:01:13.000+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
07-11 22:01:13.080+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-11 22:01:13.130+0800 W/AUL     (  516): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(505) type(wakeup)
07-11 22:01:13.135+0800 E/RESOURCED(  628): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 505
07-11 22:01:13.150+0800 E/ALARM_MANAGER(  505): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [1202817990]
07-11 22:01:13.150+0800 W/WECONN  (  505): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
07-11 22:01:13.150+0800 W/WECONN  (  505): <wc_manager_get_bearer_state:988> type : 1
07-11 22:01:13.150+0800 W/WECONN  (  505): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
07-11 22:01:13.150+0800 W/WECONN  (  505): <__connect_for_auto_switch:1706> { device=0x42901b58, device->bt_address=1E:F0
07-11 22:01:13.175+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_expired(1445) > alarm_id[1202817990] is expired.
07-11 22:01:13.175+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1202817990)
07-11 22:01:13.175+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-11 22:01:13.175+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-7-2017, 15:59:08 (UTC).
07-11 22:01:13.175+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-11 22:01:13.180+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
07-11 22:01:13.210+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-11 22:01:13.320+0800 W/WECONN  (  505): <__connect_for_auto_switch:1719> }
07-11 22:01:13.320+0800 W/WECONN  (  505):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
07-11 22:01:13.320+0800 W/WECONN  (  505): <__wc_device_try_to_connect_on_wear:185> }
07-11 22:01:14.875+0800 E/EFL     ( 3479): ecore_x<3479> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1501830 button=1
07-11 22:01:14.875+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:14.880+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:14.880+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:14.885+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:14.885+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:14.900+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:14.900+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:14.910+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:14.910+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:14.920+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:14.920+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:14.930+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:14.930+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:14.930+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] add hold animator
07-11 22:01:14.940+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:14.940+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:14.945+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] direction_x(0), direction_y(1)
07-11 22:01:14.945+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] drag_child_locked_y(0)
07-11 22:01:14.945+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x417e96d8 : elm_genlist] move content x(0), y(51)
07-11 22:01:14.990+0800 E/EFL     ( 3479): ecore_x<3479> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1501942 button=1
07-11 22:01:14.990+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:14.990+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:14.990+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:14.990+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:14.990+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:14.990+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:15.790+0800 E/EFL     ( 3479): ecore_x<3479> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1502723 button=1
07-11 22:01:15.790+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:15.790+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:15.790+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:15.825+0800 E/EFL     ( 3479): ecore_x<3479> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1502776 button=1
07-11 22:01:15.825+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-11 22:01:15.825+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-11 22:01:16.075+0800 I/efl-extension( 3479): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 22:01:16.075+0800 I/efl-extension( 3479): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4187df98, elm_image, _activated_obj : 0x445074d8, activated : 1
07-11 22:01:16.075+0800 I/efl-extension( 3479): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-11 22:01:16.095+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447311e8 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-11 22:01:16.095+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447311e8 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-11 22:01:16.110+0800 E/EFL     ( 3479): elementary<3479> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 22:01:16.120+0800 E/EFL     ( 3479): elementary<3479> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4472c538) will be pushed
07-11 22:01:16.120+0800 I/efl-extension( 3479): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44d2ebc8]'s widget[0x44d25bd8] to layout widget[0x4472c538]
07-11 22:01:16.125+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447311e8 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 22:01:16.125+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447311e8 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 22:01:16.125+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447311e8 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 22:01:16.125+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447311e8 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 22:01:16.125+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447311e8 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 22:01:16.125+0800 E/EFL     ( 3479): elementary<3479> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447311e8 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 22:01:16.125+0800 I/efl-extension( 3479): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 22:01:16.155+0800 E/EFL     ( 3479): elementary<3479> elc_naviframe.c:2796 _push_transition_cb() item(0x4472c538) will transition
07-11 22:01:16.575+0800 E/EFL     ( 3479): elementary<3479> elc_naviframe.c:1193 _on_item_push_finished() item(0x44507940) transition finished
07-11 22:01:16.575+0800 E/EFL     ( 3479): elementary<3479> elc_naviframe.c:1218 _on_item_show_finished() item(0x4472c538) transition finished
07-11 22:01:16.610+0800 I/APP_CORE(  824): appcore-efl.c: __do_app(453) > [APP 824] Event: MEM_FLUSH State: PAUSED
07-11 22:01:16.865+0800 E/EFL     ( 3479): ecore_x<3479> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1503822 button=1
07-11 22:01:16.925+0800 E/EFL     ( 3479): ecore_x<3479> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1503880 button=1
07-11 22:01:16.925+0800 E/EFL     ( 3479): elementary<3479> elm_widget.c:4382 elm_widget_type_check() Passing Object: 0x44731070 in function: elm_naviframe_item_pop, of type: 'rectangle' when expecting type: 'elm_naviframe'
07-11 22:01:18.490+0800 W/WECONN  (  505): <__on_connect_socket:378> {
07-11 22:01:18.490+0800 W/WECONN  (  505): <__is_device_matched_to:2560> le : , br_edr : 1E:F0, identifier : 1E:F0
07-11 22:01:18.490+0800 W/WECONN  (  505): <__on_connect_socket:383> result(-29359863), state(0)
07-11 22:01:18.490+0800 W/WECONN  (  505): <__on_connect_socket:387> }
07-11 22:01:33.030+0800 E/RESOURCED(  628): block-monitor.c: block_logging(123) > pid 3479(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/2017-07-11-22-0-1-acc.txt
07-11 22:01:33.055+0800 E/RESOURCED(  628): block-monitor.c: block_logging(123) > pid 3479(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/2017-07-11-22-0-1-gyr.txt
07-11 22:01:41.625+0800 W/SHealthCommon( 1120): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499731200000.000000[0;m
07-11 22:01:41.690+0800 W/SHealthCommon( 1120): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-11 22:01:41.715+0800 I/HealthDataService( 1000): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-11 22:01:41.755+0800 I/healthData( 1120): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-11 22:01:44.975+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-11 22:01:46.000+0800 W/CRASH_MANAGER( 3628): worker.c: worker_job(1205) > 110347973656e149978170
