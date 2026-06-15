import 'package:flutter/material.dart';

class CriticalDirectivesSection extends StatelessWidget {
  const CriticalDirectivesSection({super.key});

  @override
  Widget build(BuildContext context) {
    return const Card(
      color: Colors.white,
      child: Padding(
        padding: EdgeInsets.symmetric(vertical: 16),
        child: Column(
          children: [
            Padding(
              padding: EdgeInsets.symmetric(horizontal: 16, vertical: 8),
              child: Text(
                'Critical Directives Queue',
                style: TextStyle(
                  fontSize: 22,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),
            SizedBox(height: 8),
            ListTile(
              leading: Icon(Icons.storage, size: 28, color: Colors.black),
              title: Text(
                'Database Consolidation',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
              ),
              subtitle: Text('Optimization in progress'),
              trailing: Icon(Icons.arrow_forward_ios, size: 18),
            ),
            Divider(height: 16),
            ListTile(
              leading: Icon(Icons.account_tree, size: 28, color: Colors.black),
              title: Text(
                'Network Link Stability',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
              ),
              subtitle: Text('Monitoring connections'),
              trailing: Icon(Icons.arrow_forward_ios, size: 18),
            ),
            Divider(height: 16),
            ListTile(
              leading: Icon(Icons.shield, size: 28, color: Colors.black),
              title: Text(
                'Firewall Rules Update',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 16),
              ),
              subtitle: Text('Applying new policies'),
              trailing: Icon(Icons.arrow_forward_ios, size: 18),
            ),
          ],
        ),
      ),
    );
  }
}
