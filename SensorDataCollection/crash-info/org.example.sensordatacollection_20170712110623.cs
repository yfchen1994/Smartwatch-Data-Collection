S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 4689
Date: 2017-07-12 11:06:23+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4689, uid 5000)

Register Information
r0   = 0x405ac250, r1   = 0x00000002
r2   = 0x44fe16c8, r3   = 0x34312e30
r4   = 0x444dfff8, r5   = 0x34312e30
r6   = 0x787f2e28, r7   = 0x405ac250
r8   = 0x00000000, r9   = 0x00000000
r10  = 0x413c1714, fp   = 0xbecd9cfc
ip   = 0x405ab030, sp   = 0xbecd9700
lr   = 0x404ef5d0, pc   = 0x404eb658
cpsr = 0x00000010

Memory Information
MemTotal:   491132 KB
MemFree:     16268 KB
Buffers:     24480 KB
Cached:     163724 KB
VmPeak:     109084 KB
VmSize:     107048 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24268 KB
VmRSS:       24268 KB
VmData:      43512 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4689 TID = 4689
4689 4812 4834 4835 4836 

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
41d27000 41df1000 r-xp /usr/lib/libCOREGL.so.4.0
41e42000 41e4d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41e56000 41e5b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41e68000 41f9d000 rw-p [heap]
43c8a000 43ca1000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43cae000 43cb0000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43cb9000 444b8000 rw-p [stack:4812]
444b8000 444b9000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444cf000 444d0000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444ee000 444f6000 r-xp /usr/lib/libfeedback.so.0.1.4
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
450c7000 458c6000 rw-p [stack:4834]
458c7000 460c6000 rw-p [stack:4835]
460c7000 46a56000 rw-p [stack:4836]
becba000 becdb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4689)
Call Stack Count: 1
 0: (0x404eb658) [/lib/libc.so.6] + 0x6e658
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
) [0x4506e9d8 : elm_scroller] cw(360), ch(360), pw(360), ph(360)
07-12 11:06:00.311+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
07-12 11:06:00.311+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 11:06:00.311+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] cw(360), ch(360), pw(360), ph(360)
07-12 11:06:00.311+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
07-12 11:06:00.326+0800 E/W_TASKMANAGER( 4392): util_wc1.c: close_button_disabled_set(377) > [close_button_disabled_set:377] (ad->ly_main == NULL) -> close_button_disabled_set() return
07-12 11:06:00.366+0800 E/W_TASKMANAGER( 4392): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
07-12 11:06:00.366+0800 E/W_TASKMANAGER( 4392): taskmanager.c: _app_create(324) > [_app_create:324] cannot init pkgmgr
07-12 11:06:00.501+0800 I/capability-manager( 4793): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
07-12 11:06:00.501+0800 I/capability-manager( 4793): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
07-12 11:06:00.506+0800 E/W_TASKMANAGER( 4392): task.c: _app_list_cb(609) > [_app_list_cb:609] pkgmgrinfo_appinfo_get_label(com.samsung.skmsa) failed(0)
07-12 11:06:00.511+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-home)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.watchface)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.shealth.widget.pedometer)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-calendar2.widget.monthly)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.weather-widget)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-music-player.widget)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (health-data-service)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-music-player.music-control-service)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.shealth-service)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.remote-sensor-service)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.wusvc)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.watchface-service)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.message.consumer)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.weip.consumer)!!
07-12 11:06:00.511+0800 E/W_TASKMANAGER( 4392): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-taskmanager)!!
07-12 11:06:00.516+0800 E/RUA     ( 4392): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 15, ncols : 5
07-12 11:06:00.531+0800 E/EFL     ( 4392): evas_main<4392> evas_stack.c:158 evas_object_stack_above() BITCH! evas_object_stack_above(), 0x46d05138 not inside same smart as 0x450c7bc8!
07-12 11:06:00.531+0800 E/EFL     ( 4392): elementary<4392> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x4509ddc0 into part 'elm.swallow.event.0'
07-12 11:06:00.561+0800 W/W_HOME  (  811): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-12 11:06:00.561+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 11:06:00.561+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 11:06:00.561+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 11:06:00.561+0800 W/W_HOME  (  811): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-12 11:06:00.561+0800 W/W_HOME  (  811): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-12 11:06:00.576+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 11:06:00.586+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 11:06:00.611+0800 I/APP_CORE( 4392): appcore-efl.c: __do_app(453) > [APP 4392] Event: RESET State: CREATED
07-12 11:06:00.611+0800 I/CAPI_APPFW_APPLICATION( 4392): app_main.c: app_appcore_reset(245) > app_appcore_reset
07-12 11:06:00.621+0800 I/APP_CORE( 4392): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-12 11:06:00.621+0800 I/APP_CORE( 4392): appcore-efl.c: __do_app(524) > [APP 4392] Initial Launching, call the resume_cb
07-12 11:06:00.621+0800 I/CAPI_APPFW_APPLICATION( 4392): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-12 11:06:00.631+0800 W/APP_CORE( 4392): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400003
07-12 11:06:00.646+0800 I/MALI    ( 4392): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-12 11:06:00.686+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-12 11:06:00.686+0800 W/W_HOME  (  811): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-12 11:06:00.686+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 11:06:00.686+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 11:06:00.686+0800 W/W_HOME  (  811): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-12 11:06:00.686+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: PAUSE State: RUNNING
07-12 11:06:00.686+0800 I/CAPI_APPFW_APPLICATION(  811): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-12 11:06:00.686+0800 W/W_HOME  (  811): main.c: _appcore_pause_cb(487) > appcore pause
07-12 11:06:00.686+0800 W/W_HOME  (  811): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-12 11:06:00.686+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 11:06:00.686+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 11:06:00.686+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 11:06:00.686+0800 W/W_HOME  (  811): rotary.c: rotary_deattach(156) > rotary_deattach:0x474c2038
07-12 11:06:00.686+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-12 11:06:00.686+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x474c2038, elm_layout, func : 0x4005653d
07-12 11:06:00.686+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-12 11:06:00.686+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-12 11:06:00.686+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-12 11:06:00.686+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e39b0, elm_box, _activated_obj : 0x474c2038, activated : 1
07-12 11:06:00.686+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 11:06:00.686+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 11:06:00.686+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-12 11:06:00.696+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(811) status(bg) type(uiapp)
07-12 11:06:00.696+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 11:06:00.696+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 11:06:00.696+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[811] goes to (4)
07-12 11:06:00.696+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 811)'s state(4)
07-12 11:06:00.701+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4392] goes to (3)
07-12 11:06:00.701+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(4392) status(fg) type(uiapp)
07-12 11:06:00.711+0800 E/TBM     (  397): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:397] error(Device or resource busy) _tgl_destroy:141 key:25
07-12 11:06:00.711+0800 W/W_HOME  (  811): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-12 11:06:00.721+0800 I/APP_CORE( 4392): appcore-efl.c: __do_app(453) > [APP 4392] Event: RESUME State: RUNNING
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-12 11:06:00.721+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 11:06:00.721+0800 E/CAPI_APPFW_APP_CONTROL( 1005): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-12 11:06:00.721+0800 W/MUSIC_CONTROL_SERVICE( 1005): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1005]   [com.samsung.w-home]register msg port [false][0m
07-12 11:06:00.726+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-12 11:06:00.726+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 11:06:00.726+0800 W/wnotib  (  811): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-12 11:06:00.776+0800 W/APPS    (  811): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-12 11:06:01.106+0800 E/AUL     (  524): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-12 11:06:01.181+0800 I/MALI    ( 4392): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414600b8] swap changed from async to sync
07-12 11:06:01.231+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 11:06:01.241+0800 E/EFL     ( 4392): ecore_x<4392> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2287673 button=1
07-12 11:06:01.241+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4506e9d8 : elm_scroller] mouse move
07-12 11:06:01.246+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4506e9d8 : elm_scroller] mouse move
07-12 11:06:01.246+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4506e9d8 : elm_scroller] hold(0), freeze(0)
07-12 11:06:01.266+0800 E/EFL     ( 4392): ecore_x<4392> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2287692 button=1
07-12 11:06:01.266+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4506e9d8 : elm_scroller] mouse move
07-12 11:06:01.266+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4506e9d8 : elm_scroller] hold(0), freeze(0)
07-12 11:06:01.296+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:06:01.311+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
07-12 11:06:01.311+0800 W/AUL     ( 4392): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-12 11:06:01.311+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 0
07-12 11:06:01.316+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(1782) > caller pid : 4392
07-12 11:06:01.316+0800 I/AUL_AMD (  524): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-12 11:06:01.326+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(2218) > pad pid(-5)
07-12 11:06:01.331+0800 W/AUL_PAD ( 1308): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-12 11:06:01.331+0800 W/AUL_PAD ( 1308): launchpad.c: __send_result_to_caller(272) > Check app launching
07-12 11:06:01.336+0800 W/AUL_PAD ( 4689): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-12 11:06:01.336+0800 W/AUL_PAD ( 4689): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-12 11:06:01.336+0800 W/AUL_PAD ( 4689): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-12 11:06:01.336+0800 W/AUL_PAD ( 4689): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-12 11:06:01.361+0800 E/RESOURCED(  600): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 1
07-12 11:06:01.406+0800 I/efl-extension( 4689): efl_extension.c: eext_mod_init(40) > Init
07-12 11:06:01.406+0800 I/UXT     ( 4689): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-12 11:06:01.421+0800 W/AUL_PAD ( 4689): launchpad_loader.c: main(690) > [candidate] dlsym
07-12 11:06:01.421+0800 W/AUL_PAD ( 4689): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-12 11:06:01.421+0800 I/CAPI_APPFW_APPLICATION( 4689): app_main.c: ui_app_main(704) > app_efl_main
07-12 11:06:01.426+0800 I/CAPI_APPFW_APPLICATION( 4689): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-12 11:06:01.431+0800 W/AUL     (  524): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(4689) type(uiapp) bg(0)
07-12 11:06:01.431+0800 W/AUL     ( 4392): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4689)
07-12 11:06:01.431+0800 E/W_TASKMANAGER( 4392): task.c: taskmanager_launch_task_info(1075) > [taskmanager_launch_task_info:1075] _launch_app() failed(4689)
07-12 11:06:01.431+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:06:01.441+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4392
07-12 11:06:01.441+0800 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (4689) was created
07-12 11:06:01.441+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:06:01.446+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4392
07-12 11:06:01.446+0800 E/AUL     (  524): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-12 11:06:01.446+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 11:06:01.451+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 11:06:01.476+0800 W/STARTER (  754): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [4689]
07-12 11:06:01.601+0800 I/efl-extension( 4689): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 11:06:01.601+0800 I/efl-extension( 4689): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-12 11:06:01.606+0800 I/efl-extension( 4689): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-12 11:06:01.606+0800 I/efl-extension( 4689): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-12 11:06:01.606+0800 I/efl-extension( 4689): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x438cdb58, elm_image, _activated_obj : 0x0, activated : 1
07-12 11:06:01.606+0800 E/EFL     ( 4689): elementary<4689> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 11:06:01.616+0800 E/EFL     ( 4689): elementary<4689> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x438cdfc0) will be pushed
07-12 11:06:01.616+0800 I/efl-extension( 4689): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x438e2d68]'s widget[0x438cf450] to layout widget[0x438cdfc0]
07-12 11:06:01.616+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4383a910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 11:06:01.616+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4383a910 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-12 11:06:01.616+0800 I/efl-extension( 4689): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 11:06:01.621+0800 I/APP_CORE( 4689): appcore-efl.c: __do_app(453) > [APP 4689] Event: RESET State: CREATED
07-12 11:06:01.621+0800 I/CAPI_APPFW_APPLICATION( 4689): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-12 11:06:01.641+0800 I/APP_CORE( 4689): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-12 11:06:01.641+0800 I/APP_CORE( 4689): appcore-efl.c: __do_app(524) > [APP 4689] Initial Launching, call the resume_cb
07-12 11:06:01.641+0800 I/CAPI_APPFW_APPLICATION( 4689): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-12 11:06:01.701+0800 W/APP_CORE( 4689): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1600002
07-12 11:06:01.706+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4383a910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 11:06:01.706+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4383a910 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-12 11:06:01.756+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4383a910 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-12 11:06:01.756+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4383a910 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-12 11:06:01.836+0800 I/APP_CORE( 4392): appcore-efl.c: __do_app(453) > [APP 4392] Event: PAUSE State: RUNNING
07-12 11:06:01.836+0800 I/CAPI_APPFW_APPLICATION( 4392): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-12 11:06:01.851+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(4392) status(bg) type(uiapp)
07-12 11:06:01.851+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4392] goes to (4)
07-12 11:06:01.851+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4689] goes to (3)
07-12 11:06:01.856+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(4689) status(fg) type(uiapp)
07-12 11:06:01.886+0800 I/APP_CORE( 4689): appcore-efl.c: __do_app(453) > [APP 4689] Event: RESUME State: RUNNING
07-12 11:06:01.886+0800 E/TBM     (  397): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:397] error(Device or resource busy) _tgl_destroy:141 key:29
07-12 11:06:01.936+0800 I/efl-extension( 4798): efl_extension.c: eext_mod_init(40) > Init
07-12 11:06:02.026+0800 I/UXT     ( 4798): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-12 11:06:02.036+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 22
07-12 11:06:02.036+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(999) > app status : 4
07-12 11:06:02.036+0800 E/APP_CORE( 4392): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
07-12 11:06:02.036+0800 I/APP_CORE( 4392): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
07-12 11:06:02.036+0800 I/CAPI_APPFW_APPLICATION( 4392): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
07-12 11:06:02.041+0800 I/efl-extension( 4392): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x4506e9d8, obj: 0x4506e9d8
07-12 11:06:02.041+0800 I/efl-extension( 4392): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
07-12 11:06:02.041+0800 I/efl-extension( 4392): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
07-12 11:06:02.041+0800 I/efl-extension( 4392): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
07-12 11:06:02.041+0800 I/efl-extension( 4392): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-12 11:06:02.046+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 11:06:02.046+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] cw(0), ch(0), pw(360), ph(360)
07-12 11:06:02.051+0800 E/EFL     ( 4392): elementary<4392> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
07-12 11:06:02.051+0800 I/efl-extension( 4392): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0x4508c0a0
07-12 11:06:02.056+0800 I/efl-extension( 4392): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-12 11:06:02.056+0800 I/efl-extension( 4392): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x450aec48 is freed
07-12 11:06:02.056+0800 I/efl-extension( 4392): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-12 11:06:02.056+0800 I/efl-extension( 4392): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4506e9d8, elm_scroller, func : 0x43912351
07-12 11:06:02.056+0800 I/efl-extension( 4392): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-12 11:06:02.056+0800 I/efl-extension( 4392): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-12 11:06:02.056+0800 I/efl-extension( 4392): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4508c0a0, elm_image, func : 0x43912351
07-12 11:06:02.056+0800 I/efl-extension( 4392): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-12 11:06:02.056+0800 I/efl-extension( 4392): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0x4506e9d8 : elm_scroller] rotary callabck is deleted
07-12 11:06:02.151+0800 I/AUL_PAD ( 4798): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-12 11:06:02.186+0800 E/MALI    ( 4798): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-12 11:06:02.186+0800 E/MALI    ( 4798): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-12 11:06:02.186+0800 E/MALI    ( 4798): [gpu-ddk] devel/graphics_drv/r4p0
07-12 11:06:02.186+0800 E/MALI    ( 4798): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-12 11:06:02.186+0800 E/MALI    ( 4798): [coregl] devel/graphics_engine/master
07-12 11:06:02.186+0800 E/MALI    ( 4798): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-12 11:06:02.186+0800 E/MALI    ( 4798): Ð
07-12 11:06:02.251+0800 E/AUL     (  524): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-12 11:06:02.281+0800 I/APP_CORE( 4392): appcore-efl.c: __after_loop(1243) > [APP 4392] After terminate() callback
07-12 11:06:02.346+0800 I/MALI    ( 4392): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
07-12 11:06:02.346+0800 I/MALI    ( 4392): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=4392   close drm_fd=23 
07-12 11:06:02.346+0800 I/MALI    ( 4392): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
07-12 11:06:02.421+0800 E/EFL     ( 4689): ecore_x<4689> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2288858 button=1
07-12 11:06:02.426+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.436+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.436+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:02.446+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.451+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:02.456+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.456+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:02.466+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.466+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:02.476+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.476+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:02.476+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] add hold animator
07-12 11:06:02.481+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x4383a910 : elm_genlist] direction_x(0), direction_y(1)
07-12 11:06:02.481+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x4383a910 : elm_genlist] drag_child_locked_y(0)
07-12 11:06:02.481+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x4383a910 : elm_genlist] move content x(0), y(37)
07-12 11:06:02.556+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:06:02.566+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4689
07-12 11:06:02.566+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:06:02.576+0800 E/EFL     ( 4689): ecore_x<4689> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2288967 button=1
07-12 11:06:02.576+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.576+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:02.576+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.576+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:02.576+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.576+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:02.576+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.576+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:02.576+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4689
07-12 11:06:02.581+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 11:06:02.581+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 11:06:02.836+0800 I/AUL_PAD ( 4807): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-12 11:06:02.996+0800 E/EFL     ( 4689): ecore_x<4689> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2289411 button=1
07-12 11:06:02.996+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.996+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:02.996+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.021+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.021+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.021+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.021+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.021+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.021+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.041+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.041+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.041+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] add hold animator
07-12 11:06:03.041+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.041+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.046+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x4383a910 : elm_genlist] direction_x(0), direction_y(1)
07-12 11:06:03.046+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x4383a910 : elm_genlist] drag_child_locked_y(0)
07-12 11:06:03.046+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x4383a910 : elm_genlist] move content x(0), y(286)
07-12 11:06:03.241+0800 I/UXT     ( 4392): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
07-12 11:06:03.241+0800 I/UXT     ( 4392): uxt_theme_private.c: uxt_theme_delete_file_monitor(1662) > deleted font config file monitor
07-12 11:06:03.241+0800 I/UXT     ( 4392): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
07-12 11:06:03.286+0800 E/EFL     ( 4689): ecore_x<4689> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2289521 button=1
07-12 11:06:03.286+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.286+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.286+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.286+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.286+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.286+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.556+0800 W/AUL_PAD ( 4392): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
07-12 11:06:03.556+0800 I/efl-extension( 4392): efl_extension.c: eext_mod_shutdown(46) > Shutdown
07-12 11:06:03.591+0800 E/EFL     ( 4689): ecore_x<4689> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2290019 button=1
07-12 11:06:03.591+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.596+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.596+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.606+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.606+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.626+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.626+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.636+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] mouse move
07-12 11:06:03.636+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4383a910 : elm_genlist] hold(0), freeze(0)
07-12 11:06:03.651+0800 E/EFL     ( 4689): ecore_x<4689> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2290085 button=1
07-12 11:06:03.721+0800 I/efl-extension( 4689): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 11:06:03.721+0800 I/efl-extension( 4689): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x43915518, elm_image, _activated_obj : 0x438cdb58, activated : 1
07-12 11:06:03.721+0800 I/efl-extension( 4689): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 11:06:03.751+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4483bb48 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-12 11:06:03.751+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4483bb48 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-12 11:06:03.756+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4392 pgid = 4392
07-12 11:06:03.756+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
07-12 11:06:03.781+0800 E/EFL     ( 4689): elementary<4689> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 11:06:03.791+0800 E/EFL     ( 4689): elementary<4689> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4483f930) will be pushed
07-12 11:06:03.791+0800 I/efl-extension( 4689): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44df55e0]'s widget[0x44debdc0] to layout widget[0x4483f930]
07-12 11:06:03.796+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4483bb48 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:06:03.796+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4483bb48 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:06:03.796+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4483bb48 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:06:03.796+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4483bb48 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:06:03.796+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4483bb48 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:06:03.796+0800 E/EFL     ( 4689): elementary<4689> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4483bb48 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:06:03.801+0800 I/efl-extension( 4689): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 11:06:03.801+0800 E/EFL     ( 4689): elementary<4689> elc_naviframe.c:2796 _push_transition_cb() item(0x4483f930) will transition
07-12 11:06:03.806+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-12 11:06:03.816+0800 I/AUL_AMD (  524): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4392
07-12 11:06:03.816+0800 W/AUL     (  524): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4392)
07-12 11:06:04.036+0800 W/AUL_AMD (  524): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
07-12 11:06:04.116+0800 E/EFL     ( 4689): elementary<4689> elc_naviframe.c:1193 _on_item_push_finished() item(0x438cdfc0) transition finished
07-12 11:06:04.116+0800 E/EFL     ( 4689): elementary<4689> elc_naviframe.c:1218 _on_item_show_finished() item(0x4483f930) transition finished
07-12 11:06:04.436+0800 E/EFL     ( 4689): ecore_x<4689> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2290868 button=1
07-12 11:06:04.496+0800 E/EFL     ( 4689): ecore_x<4689> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2290927 button=1
07-12 11:06:05.496+0800 E/EFL     (  397): ecore_x<397> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1600002 time=2290927
07-12 11:06:05.501+0800 E/EFL     ( 4689): ecore_x<4689> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=2290927
07-12 11:06:05.511+0800 E/EFL     (  397): ecore_x<397> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=2290927
07-12 11:06:05.731+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 11:06:13.326+0800 W/SHealthCommon( 1107): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499817600000.000000[0;m
07-12 11:06:13.406+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-12 11:06:13.421+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:06:13.446+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:06:20.601+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-12 11:06:23.061+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 4689(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/2017-07-12-11-0-6-acc.txt
07-12 11:06:23.091+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 4689(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/2017-07-12-11-0-6-gyr.txt
07-12 11:06:23.481+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 4689(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/2017-07-12-11-0-6-acc.txt
07-12 11:06:23.481+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 4689(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/2017-07-12-11-0-6-gyr.txt
07-12 11:06:23.481+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4689 pgid = 4689
07-12 11:06:23.481+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-12 11:06:23.506+0800 I/MALI    (  811): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-12 11:06:23.511+0800 W/CRASH_MANAGER( 4873): worker.c: worker_job(1205) > 110468973656e149982878
