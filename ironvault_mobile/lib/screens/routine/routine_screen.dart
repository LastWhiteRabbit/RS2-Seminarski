import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:ironvault_mobile/model/routine.dart';
import 'package:ironvault_mobile/providers/routine_provider.dart';
import 'package:ironvault_mobile/screens/routine/routine_details_screen.dart';
import 'package:ironvault_mobile/widgets/master_screen.dart';
import 'package:provider/provider.dart';

import '../../utils/util.dart';

class RoutineScreen extends StatefulWidget {
  static const String routeName = "/Routine";

  const RoutineScreen({Key? key}) : super(key: key);

  @override
  State<RoutineScreen> createState() => _RoutineScreenState();
}

class _RoutineScreenState extends State<RoutineScreen> {
  RoutineProvider? _routineProvider = null;
  List<Routine> data = [];

  double _drawerIconSize = 24;
  double _drawerFontSize = 17;
  @override
  void initState() {
    super.initState();
    _routineProvider = context.read<RoutineProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _routineProvider?.get(null);

    setState(() {
      data = tmpData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: SingleChildScrollView(
        child: Container(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              _buildHeader(),
              Container(
                height: 500,
                child: GridView(
                  gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                      crossAxisCount: 1,
                      childAspectRatio: 4 / 3,
                      crossAxisSpacing: 1.0,
                      mainAxisSpacing: 1.0),
                  scrollDirection: Axis.vertical,
                  children: _buildRoutineList(),
                ),
              ),
              Container(
                height: 500,
                child: GridView(
                  gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                      crossAxisCount: 1,
                      childAspectRatio: 4 / 3,
                      crossAxisSpacing: 1.0,
                      mainAxisSpacing: 1.0),
                  scrollDirection: Axis.vertical,
                  children: _buildRoutineCardList(),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "Routines",
        style: TextStyle(
            color: Colors.grey, fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }

  List<Widget> _buildRoutineList() {
    if (data.length == 0) {
      return [Text("Loading...")];
    }
    List<Widget> list = data
        .map((x) => Column(
              children: [
                Container(
                  child: Container(
                    height: 10,
                    width: 100,
                    child: Text(x.routineName!),
                  ),
                ),
              ],
            ))
        .cast<Widget>()
        .toList();

    return list;
  }

  List<Widget> _buildRoutineCardList() {
    if (data.length == 0) {
      return [Text("Loading...")];
    }
    List<Widget> list = data
        .map((x) => Container(
                child: Column(
              children: [
                Container(
                  child: Container(
                    height: 100,
                    width: 100,
                    child: Text(x.routineName!),
                  ),
                ),
              ],
            )))
        .cast<Widget>()
        .toList();

    return list;
  }
}
