import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:ironvault_mobile/model/routine.dart';
import 'package:ironvault_mobile/providers/routine_provider.dart';
import 'package:ironvault_mobile/utils/util.dart';
import 'package:ironvault_mobile/widgets/master_screen.dart';
import 'package:provider/provider.dart';

class RoutineDetailsScreen extends StatefulWidget {
  static const String routeName = "/RoutineDetails";
  String id;
  RoutineDetailsScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<RoutineDetailsScreen> createState() => _RoutineDetailsScreenState();
}

class _RoutineDetailsScreenState extends State<RoutineDetailsScreen> {
  RoutineProvider? _routineProvider;

  Routine? data;

  @override
  void initState() {
    super.initState();
    _routineProvider = context.read<RoutineProvider>();
    loadData();
  }

  Future loadData() async {
    var tmpData = await _routineProvider?.getById(int.parse(widget.id));
    setState(() {
      data = tmpData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (data == null) {
      return const Text('');
    }

    return MasterScreenWidget(
      child: SingleChildScrollView(
          child: Container(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            _buildHeader(),
            SizedBox(height: 30.0),
            Container(
              child: TextFormField(
                readOnly: true,
                initialValue: data!.routineName,
                decoration: InputDecoration(
                  labelText: 'Name',
                  border: OutlineInputBorder(),
                ),
              ),
            ),
            SizedBox(height: 30.0),
            Container(
              child: TextFormField(
                readOnly: true,
                maxLines: 8,
                initialValue: data?.description,
                decoration: InputDecoration(
                  labelText: 'Description',
                  border: OutlineInputBorder(),
                ),
                style: TextStyle(
                  fontSize: 20,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),
          ],
        ),
      )),
    );
  }

  Widget _buildHeader() {
    return Container(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: Text(
        "${data?.routineName}",
        style: TextStyle(
            color: Colors.grey, fontSize: 40, fontWeight: FontWeight.w600),
      ),
    );
  }
}
